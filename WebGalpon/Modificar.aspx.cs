using bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;

namespace WebGalpon
{
    public partial class Modificar : System.Web.UI.Page
    {
        InfoMayoristaNegocio infoNegocio = new InfoMayoristaNegocio(); 
        List<InfoMayorista> infoNegocioList = new List<InfoMayorista>();

        PreguntaFrecuenteNegocio pregFrec = new PreguntaFrecuenteNegocio();
        List<PreguntaFrecuente> pregFrecList = new List<PreguntaFrecuente>();

        NovedadNegocio novedadNegocio = new NovedadNegocio();
        List<Novedad> novedadList = new List<Novedad>();

        DestacadoNegocio destacadoNegocio = new DestacadoNegocio();
        List<Destacado> destacadoList = new List<Destacado>();  
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["usuario"];

            if ((Session["usuario"] != null) && (user.TipoUsuario == TipoUsuario.ADMIN))
            {

            }
            else
            {
                Session.Add("error", "No tienes permisos para ver este sitio");
                Response.Redirect("Error.aspx");
            }


            if (!IsPostBack)
            {
                infoNegocioList = infoNegocio.Listar();

                DDLModInfo.DataSource = infoNegocioList;
                DDLModInfo.DataTextField = "Titulo";
                DDLModInfo.DataValueField = "IdInfo";
                DDLModInfo.DataBind();

                DDLEliminarInfo.DataSource = infoNegocioList;
                DDLEliminarInfo.DataTextField = "Titulo";
                DDLEliminarInfo.DataValueField = "IdInfo";
                DDLEliminarInfo.DataBind();


                //------------------------------------------------

                pregFrecList = pregFrec.ListarFaq();

                DDLModPreg.DataSource = pregFrecList;
                DDLModPreg.DataTextField = "Pregunta";
                DDLModPreg.DataValueField = "IdPregunta";
                DDLModPreg.DataBind();

                DDLElimPreg.DataSource = pregFrecList;
                DDLElimPreg.DataTextField = "Pregunta";
                DDLElimPreg.DataValueField = "IdPregunta";
                DDLElimPreg.DataBind();

                //------------------------------------------------

                novedadList = novedadNegocio.ListarNovedades();

                DDLModNov.DataSource = novedadList;
                DDLModNov.DataTextField = "Titulo";
                DDLModNov.DataValueField = "IdNovedad";
                DDLModNov.DataBind();

                DDLElimNov.DataSource = novedadList;
                DDLElimNov.DataTextField = "Titulo";
                DDLElimNov.DataValueField = "IdNovedad";
                DDLElimNov.DataBind();

                //------------------------------------------------

                destacadoList = destacadoNegocio.Listar();

                DDLModDest.DataSource = destacadoList;
                DDLModDest.DataTextField = "Nombre";
                DDLModDest.DataValueField = "IdDestacado";
                DDLModDest.DataBind();

                DDLElimDest.DataSource = destacadoList;
                DDLElimDest.DataTextField = "Nombre";
                DDLElimDest.DataValueField = "IdDestacado";
                DDLElimDest.DataBind();

            }

        }











        protected void AgregarInfo_Click(object sender, EventArgs e)
        {
            infoNegocio.AgregarInfo(Titulo.Text, Desc1.Text, Desc2.Text);

            infoNegocioList = infoNegocio.Listar();

            DDLModInfo.DataSource = infoNegocioList;
            DDLModInfo.DataTextField = "Titulo";
            DDLModInfo.DataValueField = "IdInfo";
            DDLModInfo.DataBind();
            DDLEliminarInfo.DataSource = infoNegocioList;
            DDLEliminarInfo.DataTextField = "Titulo";
            DDLEliminarInfo.DataValueField = "IdInfo";
            DDLEliminarInfo.DataBind();
        }

        protected void ModificarInfo_Click(object sender, EventArgs e)
        {
            infoNegocio.ModificarInfo(ModTitulo.Text, ModDesc1.Text, ModDesc2.Text, Convert.ToInt32(DDLModInfo.SelectedItem.Value));

            infoNegocioList = infoNegocio.Listar();

            DDLModInfo.DataSource = infoNegocioList;
            DDLModInfo.DataTextField = "Titulo";
            DDLModInfo.DataValueField = "IdInfo";
            DDLModInfo.DataBind();
            DDLEliminarInfo.DataSource = infoNegocioList;
            DDLEliminarInfo.DataTextField = "Titulo";
            DDLEliminarInfo.DataValueField = "IdInfo";
            DDLEliminarInfo.DataBind();
        }

        protected void EliminarInfo_Click(object sender, EventArgs e)
        {
            infoNegocio.EliminarInfo(Convert.ToInt32(DDLEliminarInfo.SelectedItem.Value));

            infoNegocioList = infoNegocio.Listar();

            DDLModInfo.DataSource = infoNegocioList;
            DDLModInfo.DataTextField = "Titulo";
            DDLModInfo.DataValueField = "IdInfo";
            DDLModInfo.DataBind();
            DDLEliminarInfo.DataSource = infoNegocioList;
            DDLEliminarInfo.DataTextField = "Titulo";
            DDLEliminarInfo.DataValueField = "IdInfo";
            DDLEliminarInfo.DataBind();
        }










        protected void AgregarPregunta_Click(object sender, EventArgs e)
        {
            pregFrec.Agregar(Preg.Text, Res.Text);

            pregFrecList = pregFrec.ListarFaq();


            DDLModPreg.DataSource = pregFrecList;
            DDLModPreg.DataTextField = "Pregunta";
            DDLModPreg.DataValueField = "IdPregunta";
            DDLModPreg.DataBind();

            DDLElimPreg.DataSource = pregFrecList;
            DDLElimPreg.DataTextField = "Pregunta";
            DDLElimPreg.DataValueField = "IdPregunta";
            DDLElimPreg.DataBind();
        }

        protected void ModPregunta_Click(object sender, EventArgs e)
        {
            pregFrec.Modificar(ModPreg.Text, ModRes.Text, Convert.ToInt32(DDLModPreg.SelectedItem.Value));

            pregFrecList = pregFrec.ListarFaq();


            DDLModPreg.DataSource = pregFrecList;
            DDLModPreg.DataTextField = "Pregunta";
            DDLModPreg.DataValueField = "IdPregunta";
            DDLModPreg.DataBind();

            DDLElimPreg.DataSource = pregFrecList;
            DDLElimPreg.DataTextField = "Pregunta";
            DDLElimPreg.DataValueField = "IdPregunta";
            DDLElimPreg.DataBind();
        }

        protected void ElimPreg_Click(object sender, EventArgs e)
        {
         
            pregFrec.Eliminar(Convert.ToInt32(DDLElimPreg.SelectedItem.Value));

            pregFrecList = pregFrec.ListarFaq();

            DDLModPreg.DataSource = pregFrecList;
            DDLModPreg.DataTextField = "Pregunta";
            DDLModPreg.DataValueField = "IdPregunta";
            DDLModPreg.DataBind();

            DDLElimPreg.DataSource = pregFrecList;
            DDLElimPreg.DataTextField = "Pregunta";
            DDLElimPreg.DataValueField = "IdPregunta";
            DDLElimPreg.DataBind();
        }











        protected void AgregarNov_Click(object sender, EventArgs e)
        {
            novedadNegocio.Agregar(TituloNov.Text, DescNov.Text, ImgNov.Text);

            novedadList = novedadNegocio.ListarNovedades();

            DDLModNov.DataSource = novedadList;
            DDLModNov.DataTextField = "Titulo";
            DDLModNov.DataValueField = "IdNovedad";
            DDLModNov.DataBind();

            DDLElimNov.DataSource = novedadList;
            DDLElimNov.DataTextField = "Titulo";
            DDLElimNov.DataValueField = "IdNovedad";
            DDLElimNov.DataBind();
        }

        protected void ModNov_Click(object sender, EventArgs e)
        {
            novedadNegocio.Modificar(TituloNov.Text, DescNov.Text, ImgNov.Text, Convert.ToInt32(DDLModNov.SelectedItem.Value));

            novedadList = novedadNegocio.ListarNovedades();

            DDLModNov.DataSource = novedadList;
            DDLModNov.DataTextField = "Titulo";
            DDLModNov.DataValueField = "IdNovedad";
            DDLModNov.DataBind();

            DDLElimNov.DataSource = novedadList;
            DDLElimNov.DataTextField = "Titulo";
            DDLElimNov.DataValueField = "IdNovedad";
            DDLElimNov.DataBind();
        }

        protected void ElimNov_Click(object sender, EventArgs e)
        {
            novedadNegocio.Eliminar(Convert.ToInt32(DDLElimNov.SelectedItem.Value));

            novedadList = novedadNegocio.ListarNovedades();

            DDLModNov.DataSource = novedadList;
            DDLModNov.DataTextField = "Titulo";
            DDLModNov.DataValueField = "IdNovedad";
            DDLModNov.DataBind();

            DDLElimNov.DataSource = novedadList;
            DDLElimNov.DataTextField = "Titulo";
            DDLElimNov.DataValueField = "IdNovedad";
            DDLElimNov.DataBind();
        }
















        protected void AgregarDest_Click(object sender, EventArgs e)
        {
            destacadoNegocio.Agregar(NombreDest.Text, DescDest.Text, ImgDest.Text);

            destacadoList = destacadoNegocio.Listar();

            DDLModNov.DataSource = destacadoList;
            DDLModNov.DataTextField = "Nombre";
            DDLModNov.DataValueField = "IdDestacado";
            DDLModNov.DataBind();

            DDLElimNov.DataSource = destacadoList;
            DDLElimNov.DataTextField = "Nombre";
            DDLElimNov.DataValueField = "IdDestacado";
            DDLElimNov.DataBind();

        }

        protected void ModDest_Click(object sender, EventArgs e)
        {
            destacadoNegocio.Modificar(NombreDest.Text, DescDest.Text, ImgDest.Text, Convert.ToInt32(DDLModDest.SelectedItem.Value));
            destacadoList = destacadoNegocio.Listar();

            DDLModNov.DataSource = destacadoList;
            DDLModNov.DataTextField = "Nombre";
            DDLModNov.DataValueField = "IdDestacado";
            DDLModNov.DataBind();

            DDLElimNov.DataSource = destacadoList;
            DDLElimNov.DataTextField = "Nombre";
            DDLElimNov.DataValueField = "IdDestacado";
            DDLElimNov.DataBind();
        }

        protected void ElimDest_Click(object sender, EventArgs e)
        {
            destacadoNegocio.Eliminar( Convert.ToInt32(DDLModDest.SelectedItem.Value));
            destacadoList = destacadoNegocio.Listar();

            DDLModNov.DataSource = destacadoList;
            DDLModNov.DataTextField = "Nombre";
            DDLModNov.DataValueField = "IdDestacado";
            DDLModNov.DataBind();

            DDLElimNov.DataSource = destacadoList;
            DDLElimNov.DataTextField = "Nombre";
            DDLElimNov.DataValueField = "IdDestacado";
            DDLElimNov.DataBind();

        }
    }
}
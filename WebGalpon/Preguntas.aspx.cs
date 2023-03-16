using bussiness;
using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGalpon
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Producto> ListaProductos;
        public List<PreguntaFrecuente> listaPreguntas;
        public List<PreguntaFrecuente> busquedaPreg;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            PreguntaFrecuenteNegocio preg = new PreguntaFrecuenteNegocio();

            try
            {
                ListaProductos = negocio.Listar();
                Session.Add("ListaProd", ListaProductos);
                listaPreguntas = preg.ListarFaq();
                Session.Add("listaPreguntas", listaPreguntas);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /// Response.Redirect("Error.aspx");
            }
        }

        protected void BotonBusqueda_Click(object sender, EventArgs e)
        {
            List<PreguntaFrecuente> Aux = (List<PreguntaFrecuente>)Session["listaPreguntas"];
            busquedaPreg = new List<PreguntaFrecuente>();

            foreach (PreguntaFrecuente item in Aux)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Pregunta, BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    busquedaPreg.Add(item);

                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(item.Respuesta, BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        busquedaPreg.Add(item);

                    }
                    
                }
            }

            if (busquedaPreg.Count == 0)
            {
                LabelBusqueda.Text = "No se han encontrado resultados";
                LabelBusqueda.Visible = true;
            }

            listaPreguntas = busquedaPreg;
            Session.Add("Buscar", busquedaPreg);
        }

        protected void Refrescar_Click(object sender, EventArgs e)
        {
            PreguntaFrecuenteNegocio preg = new PreguntaFrecuenteNegocio();
            listaPreguntas = preg.ListarFaq();
            LabelBusqueda.Visible = false;
        }
    }
}
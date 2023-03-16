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
    public partial class InfoMayoristas : System.Web.UI.Page
    {
        public List<InfoMayorista> listaMayo;
        public List<InfoMayorista> busquedaMayo;
        protected void Page_Load(object sender, EventArgs e)
        {
            InfoMayoristaNegocio preg = new InfoMayoristaNegocio();

            try
            {
                listaMayo = preg.Listar();
                Session.Add("listaInfoMayorista", listaMayo);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /// Response.Redirect("Error.aspx");
            }
        }

        protected void BotonBusqueda_Click(object sender, EventArgs e)
        {
            List<InfoMayorista> Aux = (List<InfoMayorista>)Session["listaInfoMayorista"];
            busquedaMayo = new List<InfoMayorista>();
            LabelBusqueda.Text = " ";

            foreach (InfoMayorista item in Aux)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.Titulo, BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    busquedaMayo.Add(item);

                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(item.Descripcion, BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        busquedaMayo.Add(item);

                    }
                    else
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.Descripcion2, BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            busquedaMayo.Add(item);

                        }

                    }
                }
            }
            if (busquedaMayo.Count == 0)
            {
                LabelBusqueda.Text = "No se han encontrado resultados";
                LabelBusqueda.Visible = true;
            }


            listaMayo = busquedaMayo;
            Session.Add("Buscar", busquedaMayo);

            

        }

        protected void Refrescar_Click(object sender, EventArgs e)
        {
            InfoMayoristaNegocio preg = new InfoMayoristaNegocio();
            listaMayo = preg.Listar();
            LabelBusqueda.Visible = false;
        }
    }
}
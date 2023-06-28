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
    public partial class Recomendados : System.Web.UI.Page
    {
        public List<Producto> listaRecomendados;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                listaRecomendados = negocio.ListarRecomendados();
                Session.Add("ListaRecomendados", listaRecomendados);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /// Response.Redirect("Error.aspx");
            }
        }
    }
}
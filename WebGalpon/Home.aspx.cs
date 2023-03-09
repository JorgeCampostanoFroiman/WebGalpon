using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bussiness;

namespace WebGalpon
{
    public partial class Home : System.Web.UI.Page
    {
        public List<Producto> ListaProductos;
        public List<Producto> ListaProductosPopulares;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                ListaProductos = negocio.Listar();
                Session.Add("ListaProductos", ListaProductos);
                ListaProductosPopulares = negocio.ListarPopulares();
                Session.Add("ListaProductosPopulares", ListaProductosPopulares);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /// Response.Redirect("Error.aspx");
            }

        }
    }
}
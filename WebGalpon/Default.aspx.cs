using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;
using bussiness;
using System.Security.Cryptography.X509Certificates;

namespace WebGalpon
{
    public partial class _Default : System.Web.UI.Page
    {
        public List<Producto> lista;
        public List<Producto> productobuscado;
        public List<Producto> busqueda;
        public void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                lista = negocio.Listar();
                Session.Add("ListaProducto", lista);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                 /// Response.Redirect("Error.aspx");
            }

            

        }
    }
}

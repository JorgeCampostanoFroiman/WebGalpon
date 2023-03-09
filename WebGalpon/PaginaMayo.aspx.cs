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
    public partial class PaginaMayo : System.Web.UI.Page
    {
        public List<Producto> items;
        ItemCarrito iten;
        public decimal total;
        public List<Producto> listaMayoristas;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio negocio = new ProductoNegocio();

                listaMayoristas = negocio.Listar();
                Session.Add("ListaMayo", listaMayoristas);

                items = (List<Producto>)Session["ListaMayo"];

                foreach (Producto item in items)
                {
                    total += item.Subtotal;
                }

                repetidor.DataSource = items;
                repetidor.DataBind();

            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }

        }
    }
}
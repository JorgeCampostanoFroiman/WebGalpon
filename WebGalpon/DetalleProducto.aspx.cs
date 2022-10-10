using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace WebGalpon
{
    public partial class DetalleProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["id"] != null)
            {
                try
                {

                    string id = Request.QueryString["id"];
                    List<Producto> listado = (List<Producto>)Session["ListaProducto"];
                    Producto seleccionado = listado.Find(x => x.Codigo == id);

                    labelNombre.Text = seleccionado.Tipo + " " + seleccionado.NombreProducto;
                    labelPrecio.Text = "$" + Convert.ToInt32(seleccionado.PrecioVenta);
                    labelDescripcion.Text = "Descripcion: " + seleccionado.Descripcion;
                    imagenProducto.ImageUrl = seleccionado.ImagenUrl;
                    labelVolver.Text = "Volver a categoría " + seleccionado.Tipo;

                    image1.ImageUrl = "https://cdn.shopify.com/s/files/1/0545/0425/9755/products/imamad5_720x.jpg?v=1663089446";
                    image2.ImageUrl = seleccionado.ImagenUrl;
                    image3.ImageUrl = "https://cdn.shopify.com/s/files/1/0545/0425/9755/products/imamad5_720x.jpg?v=1663089446";
                    image4.ImageUrl = seleccionado.ImagenUrl;
                    image5.ImageUrl = "https://cdn.shopify.com/s/files/1/0545/0425/9755/products/imamad5_720x.jpg?v=1663089446";

                    image6.ImageUrl = seleccionado.ImagenUrl;
                    image7.ImageUrl = seleccionado.ImagenUrl;
                    image8.ImageUrl = seleccionado.ImagenUrl;

                    related1.Text = seleccionado.Tipo + " " + seleccionado.NombreProducto;
                    related2.Text = seleccionado.Tipo + " " + seleccionado.NombreProducto;
                    related3.Text = seleccionado.Tipo + " " + seleccionado.NombreProducto;

                    relatedp1.Text = "$" + Convert.ToInt32(seleccionado.PrecioVenta);
                    relatedp2.Text = "$" + Convert.ToInt32(seleccionado.PrecioVenta);
                    relatedp3.Text = "$" + Convert.ToInt32(seleccionado.PrecioVenta);

                }

                catch (Exception)
                {
                    Response.Redirect("Error.aspx");
                }
            }
            else
            {

            }
            
        }
    }
}
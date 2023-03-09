using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;
using bussiness;

namespace WebGalpon
{
    public partial class DetalleProducto : System.Web.UI.Page
    {
        public List<Producto> ListaProductos;
        public List<Producto> listaMedidas;
        bool cont = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            if ((Request.QueryString["id"]) != null)
            {


                try
                {
                    listaMedidas = negocio.Variantes(Request.QueryString["id"]);
                    Session.Add("ListaProducto", listaMedidas);

                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    /// Response.Redirect("Error.aspx");
                }
            }
            else
            {
                
            }



            if (Request.QueryString["id"] != null && cont == false )
            {
                
                try
                {
                    cont = true;

                    string id = Request.QueryString["id"];
                    List<Producto> listado = (List<Producto>)Session["ListaProducto"];
                    Producto seleccionado = listado.Find(x => x.Codigo == id);

                    labelNombre.Text = seleccionado.Tipo + " " + seleccionado.NombreProducto;
                    labelPrecio.Text = "$" + Convert.ToInt32(seleccionado.PrecioVenta);
                    labelDescripcion.Text = "Descripcion: " + seleccionado.Descripcion;
                    imagenProducto.ImageUrl = seleccionado.ImagenUrl;
                    labelVolver.Text = "Volver a categoría " + seleccionado.Tipo;

                    // ListaProductos = negocio.Variantes(Convert.ToInt32(seleccionado.Codigo));
                    ListaProductos = negocio.Listar();

                    ddlVariantes.DataSource = ListaProductos;
                    ddlVariantes.DataBind();
                    ddlVariantes.DataTextField = "Codigo";
                    ddlVariantes.DataValueField = "Codigo";
                    ddlVariantes.DataBind();




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

        protected void ddlVariantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = Convert.ToString(ddlVariantes.Text);
            List<Producto> listado = (List<Producto>)Session["ListaProducto"];
            Producto seleccionado = listado.Find(x => x.Codigo == id);

            imagenProducto.ImageUrl = seleccionado.ImagenUrl;
        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx?id=https://cdn.shopify.com/s/files/1/0545/0425/9755/products/imamad5_720x.jpg?v=1663089446");
        }
    }
}
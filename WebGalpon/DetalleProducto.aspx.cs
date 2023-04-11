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
        public List<Producto> listaRecomendados;
        public List<Categoria> listaCategorias;
        public List<Tipo> listaTipos;
        bool cont = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            CategoriaNegocio catneg = new CategoriaNegocio();
            TipoNegocio tipneg = new TipoNegocio(); 

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
                    labelVolver.Text = "Volver a: " + seleccionado.Tipo;
                    HL2.Text =  seleccionado.Tipo;
                    HL3.Text =  seleccionado.Categoria;


                    listaRecomendados = negocio.Recomendados(seleccionado.Tipo);

                    ListaProductos = negocio.Listar();

                    listaTipos = tipneg.Listar();
                    listaCategorias = catneg.Listar();

                    foreach (Tipo tipo in listaTipos)
                    {
                        if(tipo.Nombre == seleccionado.Tipo)
                        {
                            HL2.NavigateUrl = "~\\Productos.aspx?tipo=" + tipo.Id;
                        }
                    }

                    foreach (Categoria cat in listaCategorias)
                    {
                        if(cat.Nombre == seleccionado.Categoria)
                        {
                            HL3.NavigateUrl = "~\\Productos.aspx?cat=" + cat.Id;
                        }
                    }


                    
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


        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx?id=https://cdn.shopify.com/s/files/1/0545/0425/9755/products/imamad5_720x.jpg?v=1663089446");
        }

    }
}
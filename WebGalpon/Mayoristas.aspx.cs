using bussiness;
using domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebGalpon
{
    public partial class Mayoristas : System.Web.UI.Page
    {
        public List<Producto> listaMayoristas;
        public List<Producto> ProductoBuscar;
        public List<Producto> Busqueda;

        public List<ItemCarrito> items;
        ItemCarrito iten;
        protected void Page_Load(object sender, EventArgs e)
        {
            items = (List<ItemCarrito>)Session["itemsList"];
            if (items == null)
                items = new List<ItemCarrito>();

            iten = new ItemCarrito();

            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                listaMayoristas = negocio.Listar();
                Session.Add("ListaProducto", listaMayoristas);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /// Response.Redirect("Error.aspx");
            }

            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    if (items.Find(x => x.ItemArt.ImagenUrl.ToString() == Request.QueryString["Id"]) == null)
                    {
                        List<Producto> listaActual = (List<Producto>)Session["ListaProductos"];
                        iten.ItemArt = listaActual.Find(x => x.ImagenUrl.ToString() == Request.QueryString["Id"]);
                        iten.Cantidad = 1;
                        iten.Subtotal = iten.Cantidad * iten.ItemArt.PrecioVenta;
                        items.Add(iten);
                    }
                    else
                    {
                        if (Request.QueryString["c"] == "r")
                        {
                            ItemCarrito elim = items.Find(x => x.ItemArt.ImagenUrl.ToString() == Request.QueryString["Id"]);
                            iten.Cantidad = elim.Cantidad - 1;
                            iten.ItemArt = elim.ItemArt;
                            iten.Subtotal = iten.Cantidad * iten.ItemArt.PrecioVenta;

                            if (iten.Cantidad == 0)
                            {
                                items.Remove(elim);
                            }
                            else
                            {
                                items.Remove(elim);
                                items.Add(iten);
                            }

                        }
                        else
                        {

                            ItemCarrito elim = items.Find(x => x.ItemArt.ImagenUrl.ToString() == Request.QueryString["Id"]);
                            iten.Cantidad = elim.Cantidad + 1;
                            iten.ItemArt = elim.ItemArt;
                            iten.Subtotal = iten.Cantidad * iten.ItemArt.PrecioVenta;
                            items.Remove(elim);
                            items.Add(iten);
                        }
                    }

                }
            }


        }

        /*SEARCH BAR*/

        protected void BotonBusqueda_Click(object sender, EventArgs e)
        {
            List<Producto> Aux = (List<Producto>)Session["ListaProducto"];
            Busqueda = new List<Producto>();

            foreach (Producto item in Aux)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.NombreProducto, BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    Busqueda.Add(item);
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(item.Codigo, BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        Busqueda.Add(item);
                    }
                    else
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.Tipo, BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            Busqueda.Add(item);

                        }
                        else
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(Convert.ToString(item.PrecioVenta), BarraBusqueda.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                            {
                                Busqueda.Add(item);

                            }

                        }


                    }
                }
            }

            listaMayoristas = Busqueda;
            Session.Add("Buscar", Busqueda);
            

        }

        protected void Refrescar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            listaMayoristas = negocio.Listar();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;
using bussiness;

namespace WebGalpon
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<ItemCarrito> items;
        ItemCarrito iten;
        public decimal total;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                items = (List<ItemCarrito>)Session["items"];
                if (items == null)
                    items = new List<ItemCarrito>();

                iten = new ItemCarrito();

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

                    if (Request.QueryString["c"] == "d")
                    {
                        ItemCarrito elim = items.Find(x => x.ItemArt.ImagenUrl.ToString() == Request.QueryString["Id"]);
                        items.Remove(elim);
                        Session.Add("items", items);
                    }

                    repetidor.DataSource = items;
                    repetidor.DataBind();

                }

                Session.Add("items", items);

                foreach (ItemCarrito item in items)
                {
                    total += item.Subtotal;
                }
            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }
            
        }

        protected void BT1_Click(string a)
        {

        }
    }
}
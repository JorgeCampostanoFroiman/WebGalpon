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
    public partial class Productos : System.Web.UI.Page
    {
        public List<Producto> listaMinoristas;
        public List<Producto> productobuscadoProd;
        public List<Producto> busquedaProd;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            try
            {
                listaMinoristas = negocio.Listar();
                Session.Add("ListaProducto", listaMinoristas);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /// Response.Redirect("Error.aspx");
            }


        }

        protected void BotonBusquedaProd_Click(object sender, EventArgs e)
        {
            List<Producto> Aux = (List<Producto>)Session["ListaProducto"];
            busquedaProd = new List<Producto>();


            foreach (Producto item in Aux)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.NombreProducto, BarraBusquedaProd.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    busquedaProd.Add(item);
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(item.Codigo, BarraBusquedaProd.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        busquedaProd.Add(item);
                    }
                    else
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.Tipo, BarraBusquedaProd.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            busquedaProd.Add(item);

                        }
                        else
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(Convert.ToString(item.PrecioVenta), BarraBusquedaProd.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                            {
                                busquedaProd.Add(item);

                            }

                        }


                    }
                }
            }



            listaMinoristas = busquedaProd;
            Session.Add("Buscar", busquedaProd);

        }

        protected void RefrescarProd_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            listaMinoristas = negocio.Listar();
        }
    }
}
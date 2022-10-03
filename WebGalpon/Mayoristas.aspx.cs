﻿using bussiness;
using domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGalpon
{
    public partial class Mayoristas : System.Web.UI.Page
    {
        public List<Producto> listaMayoristas;
        public List<Producto> ProductoBuscar;
        public List<Producto> Busqueda;
        protected void Page_Load(object sender, EventArgs e)
        {
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
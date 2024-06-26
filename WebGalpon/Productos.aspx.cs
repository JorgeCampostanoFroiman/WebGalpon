﻿using bussiness;
using domain;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<Producto> listaProdXTematica;

        public List<Tematica> listaTematicas;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            TematicaNegocio temNegocio = new TematicaNegocio();
            listaTematicas = temNegocio.Listar();

            

            if ((Request.QueryString["tipo"]) != null)
            {
                try
                {
                    listaMinoristas = negocio.ListarPorTipo(Request.QueryString["tipo"]);
                    Session.Add("ListaProducto", listaMinoristas);

                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    /// Response.Redirect("Error.aspx");
                }
            }
            else if ((Request.QueryString["tem"]) != null)
            {
                try
                {
                    listaMinoristas = negocio.ListarProductosTematica(Convert.ToInt32(Request.QueryString["tem"]));
                    Session.Add("ListaProducto", listaMinoristas);

                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    /// Response.Redirect("Error.aspx");
                }
            }
            else
            {
                if ((Request.QueryString["cat"]) != null)
                {
                    try
                    {
                        listaMinoristas = negocio.ListarPorCategoria(Request.QueryString["cat"]);
                        Session.Add("ListaProducto", listaMinoristas);

                    }
                    catch (Exception ex)
                    {
                        Session.Add("Error", ex.ToString());
                        /// Response.Redirect("Error.aspx");
                    }
                }
                else
                {
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
            }
        }

        protected void BotonBusquedaProd_Click(object sender, EventArgs e)
        {
            ProductoNegocio prodNeg = new ProductoNegocio();
            List<Producto> Aux = prodNeg.Listar();
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
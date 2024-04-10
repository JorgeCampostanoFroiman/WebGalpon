using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bussiness;

namespace WebGalpon
{
    public partial class Home : System.Web.UI.Page
    {
        public List<Producto> ListaProductos;
        public List<Producto> ListaProductosPopulares;
        public List<Novedad> ListaNovedades;
        public List<Novedad> ListaNovedadesAnteriores;
        public Novedad UltimaNovedad;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            NovedadNegocio novedad = new NovedadNegocio();

            try
            {
                ListaProductos = negocio.Listar();
                Session.Add("ListaProductos", ListaProductos);

                ListaProductosPopulares = negocio.ListarRecomendados();
                Session.Add("ListaProductosPopulares", ListaProductosPopulares);

                ListaNovedades = novedad.ListarNovedades();
                Session.Add("ListaNovedades", ListaNovedades);

                ListaNovedadesAnteriores = novedad.ListarAnterioresNovedades();
                Session.Add("ListaNovedadesAnteriores", ListaNovedadesAnteriores);

                UltimaNovedad = novedad.ListarUltimaNovedad();
                Session.Add("UltimaNovedad", UltimaNovedad);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /// Response.Redirect("Error.aspx");
            }

        }
    }
}
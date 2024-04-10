using bussiness;
using domain;
using System;
using System.Collections.Generic;

namespace WebGalpon
{
    public partial class Muestra : System.Web.UI.Page
    {
        
        public List<domain.Muestra> listaMuestras;
        public List<domain.Muestra> busquedaMuestra;
        public List<Producto> busquedaProducto;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Request.QueryString["cat"]) == null)
            {
                try
                {
                    MuestraNegocio negocio = new MuestraNegocio();
                    listaMuestras = negocio.ListarPorCategoria("1000", "2000");
                    Session.Add("ListaMuestras", listaMuestras);
                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    Response.Redirect("Error.aspx");
                }
            }
            else
            {
                try
                {
                    int desde = Convert.ToInt32(Request.QueryString["cat"]);
                    int hasta = desde + 1000;
                    MuestraNegocio negocio = new MuestraNegocio();
                    listaMuestras = negocio.ListarPorCategoria(desde.ToString(), hasta.ToString());
                    Session.Add("ListaMuestras", listaMuestras);

                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    Response.Redirect("Error.aspx");
                }
            }


            
        }

        protected void BotonBusquedaProd_Click(object sender, EventArgs e)
        {
            MuestraNegocio muesNeg = new MuestraNegocio();
            List<domain.Muestra> todasLasMuestras = new List<domain.Muestra>();
            todasLasMuestras = muesNeg.Listar();
            busquedaMuestra = new List<domain.Muestra>();

            ProductoNegocio prodNeg = new ProductoNegocio();
            List<Producto> prod = prodNeg.Listar();


            foreach (Producto item in prod)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(item.NombreProducto, BarraBusquedaProd.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    foreach (domain.Muestra muestra in todasLasMuestras)
                    {
                        if (muestra.Codigo == item.Codigo)
                        {
                            busquedaMuestra.Add(muesNeg.ListarUno(muestra.Codigo));
                        }
                    }
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(item.Codigo, BarraBusquedaProd.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        foreach (domain.Muestra muestra in todasLasMuestras)
                        {
                            if (muestra.Codigo == item.Codigo)
                            {
                                busquedaMuestra.Add(muesNeg.ListarUno(muestra.Codigo));
                            }
                        }

                    }
                }
            }

            listaMuestras = busquedaMuestra;
            Session.Add("Buscar", busquedaMuestra);

        }


    }
}
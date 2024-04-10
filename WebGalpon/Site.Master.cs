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
    public partial class SiteMaster : MasterPage
    {
        public List<Producto> listaMayoristas;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            listaMayoristas = negocio.Listar();
            Session.Add("ListaMayo", listaMayoristas);


            if (Session["usuario"] == null)
            {

                LiMayoristas.Visible = false;
                LiOfertas.Visible = false;
                LiCompraRapida.Visible = false;
                modMenu.Visible = false;

            }
            else if (((domain.Usuario)Session["usuario"]).TipoUsuario == domain.TipoUsuario.NORMAL)
            {
                LiMayoristas.Visible = true;
                LiOfertas.Visible = true;
                LiCompraRapida.Visible = true;
                modMenu.Visible = false;
            }
            else
            {

            }

        }
    }
}
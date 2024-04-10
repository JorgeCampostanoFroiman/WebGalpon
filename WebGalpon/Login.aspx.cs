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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"] != null)
            {
                textContraseña.Visible = false;
                textUsuario.Visible = false;
                labelLogueado.Visible = true;
                labelLogueado.Text = "Ya estas logueado como " + Session["nombreusuario"];
                btnIngreso.Visible = false;
                btnDesloguear.Visible = true;
            }
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            Usuario newUser;
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                usuario = new Usuario(textContraseña.Text, textUsuario.Text, false);
                if (negocio.Loguear(usuario) == true)
                {
                    newUser = negocio.usuarioLogueado(usuario.NombreUsuario);
                    Session.Add("usuario", newUser);
                    Session.Add("nombreusuario", newUser.NombreUsuario);
;                   Response.Redirect("Home.aspx", false);
                }
                else
                {
                    Session.Add("error", "Usuario o contraseña incorrectos");
                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (Exception)
            {
                Session.Add("Error", "Excepcion encontrada, pero la capturamos!");
                Response.Redirect("Error.aspx");
            }
        }

        protected void btnDesloguear_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("Login.aspx");
        }
    }
}
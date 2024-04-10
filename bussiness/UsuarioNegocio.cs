using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class UsuarioNegocio
    {
        public bool Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdUsuario, IdTipoUsuario FROM Usuario Where NombreUsuario = @nombreusuario AND Contraseña = @contraseña");
                datos.setearParametro("@nombreusuario", usuario.NombreUsuario);
                datos.setearParametro("@contraseña", usuario.Contraseña);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    usuario.IdUsuario = (int)datos.Lector["IdUsuario"];
                    usuario.TipoUsuario = (int)(datos.Lector["IdTipoUsuario"]) == 2 ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public Usuario usuarioLogueado(string nombreUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select NombreUsuario, Nombre, Apellido, Telefono, Email, Contraseña, IdTipoUsuario, Dni FROM Usuario Where NombreUsuario = @nombreusuario");
                datos.setearParametro("@nombreusuario", nombreUsuario);
                datos.ejecutarLectura();

                Usuario logueado = new Usuario();

                while (datos.Lector.Read())
                {

                    logueado.TipoUsuario = (int)(datos.Lector["IdTipoUsuario"]) == 2 ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
                    logueado.Nombre = (string)datos.Lector["Nombre"];
                    logueado.Apellido = (string)datos.Lector["Apellido"];
                    logueado.Email = (string)datos.Lector["Email"];
                    logueado.NombreUsuario = (string)datos.Lector["NombreUsuario"];
                    logueado.Contraseña = (string)datos.Lector["Contraseña"];
                    logueado.Dni = (int)datos.Lector["Dni"];
                    if (datos.Lector["Telefono"] is System.DBNull)
                    {

                        logueado.Telefono = "No especificado";
                    }
                    else
                    {
                        logueado.Telefono = (string)datos.Lector["Telefono"];
                    }

                }

                return logueado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool ListarPorDNI(int dni)
        {
            bool bandera = false;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Dni From Usuario");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    if (Convert.ToInt32((string)datos.Lector["Dni"]) == dni)
                    {
                        bandera = true;
                    }
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }

        public void Agregar(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.NombreUsuario + "','" + nuevo.Nombre + "', '" + nuevo.Apellido + "', '" + nuevo.Telefono + "', '" + nuevo.Email + "', '" + nuevo.Contraseña + "', '" + nuevo.Dni + "')";
                datos.setearConsulta("insert into Usuario (NombreUsuario, Nombre, Apellido, Telefono, Email, Contraseña, Dni) " + valores);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}

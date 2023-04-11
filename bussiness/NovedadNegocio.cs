using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class NovedadNegocio
    {
        public List<Novedad> ListarNovedades()
        {
            List<Novedad> lista = new List<Novedad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Titulo, Descripcion, ImagenUrl from Novedades");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Novedad aux = new Novedad();
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    lista.Add(aux);
                }
                return lista;
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

        public void Agregar(string titulo, string desc, string img)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Novedades(Titulo, Descripcion, ImagenUrl) values('" + titulo + "','" + desc + "','" + img + "')");
                datos.ejecutarAccion();
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

        public void Modificar(string titulo, string desc, string img, int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Novedades \r\n set Titulo = '" + titulo + "', Descripcion = '" + desc + "'  , Descripcion2 = '" + img + "'\r\nWhere IdNovedad = " + id + "");
                datos.ejecutarAccion();
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

        public void Eliminar(int codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Novedades where IdNovedad = " + codigo);
                datos.ejecutarLectura();
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
    }
}

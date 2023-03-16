using domain;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}

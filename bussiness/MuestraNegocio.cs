using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class MuestraNegocio
    {


        public List<Muestra> Listar()
        {
            List<Muestra> lista = new List<Muestra>();
            AccesoDatos datos = new AccesoDatos();
            try
            {


                datos.setearConsulta("select CodigoMuestra, ImagenUrl from Muestra");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Muestra aux = new Muestra();
                    aux.Codigo = (string)datos.Lector["CodigoMuestra"];
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

        public Muestra ListarUno(string codigo)
        {
            
            AccesoDatos datos = new AccesoDatos();
            try
            {
                Muestra aux = new Muestra();

                datos.setearConsulta("select CodigoMuestra, ImagenUrl from Muestra where CodigoMuestra = '" + codigo + "'");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {                    
                    aux.Codigo = (string)datos.Lector["CodigoMuestra"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                }
                return aux;
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



        public List<Muestra> ListarPorCategoria(string desde, string hasta)
        {
            List<Muestra> lista = new List<Muestra>();
            AccesoDatos datos = new AccesoDatos();
            try
            {


                datos.setearConsulta("select CodigoMuestra, ImagenUrl from Muestra where CodigoMuestra BETWEEN " + desde + " and "  + hasta + " " );
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Muestra aux = new Muestra();
                    aux.Codigo = (string)datos.Lector["CodigoMuestra"];
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

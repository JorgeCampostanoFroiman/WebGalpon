using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class TipoNegocio
    {
        public List<Tipo> Listar()
        {
            List<Tipo> lista = new List<Tipo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select NombreTipo, Descripcion, IdTipo, PrecioMayorista, PrecioMinorista from Tipo");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Tipo aux = new Tipo();
                    aux.Nombre = (string)datos.Lector["NombreTipo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Id = (int)datos.Lector["IdTipo"];
                    aux.PrecioMayorista = (decimal)datos.Lector["PrecioMayorista"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
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

        public void ModificarPrecio(int PMayor, int PMinor, int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Tipo set PrecioMayorista = " + PMayor + ",PrecioMinorista = " + PMinor + " where IdTipo = ' " + ID + "'");
                datos.ejecutarLectura();
               
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarPrecioMayorista(int PMayor, int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Tipo set PrecioMayorista = " + PMayor + " where IdTipo = ' " + ID + "'");
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

        public decimal PrecioPorTipo(int ID)
        {
            decimal precio = 0;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select NombreTipo, Descripcion, IdTipo, PrecioMayorista, PrecioMinorista from Tipo where IdTipo = '" + ID + "'");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    precio = (decimal)datos.Lector["PrecioMayorista"];
                }
                return precio;
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

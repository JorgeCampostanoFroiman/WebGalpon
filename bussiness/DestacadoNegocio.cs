using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class DestacadoNegocio
    {
        public List<Destacado> Listar()
        {
            List<Destacado> lista = new List<Destacado>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Nombre, Descripcion, Codigo, IdDestacado from Destacados");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Destacado aux = new Destacado();
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.IdDestacado = (int)datos.Lector["IdDestacado"];
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

        public void Agregar(string nombre, string desc, string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Destacados(Nombre, Descripcion, Codigo) values('" + nombre + "','" + desc + "','" + codigo + "')");
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

        public void Modificar(string nombre, string desc, string codigo, int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Destacados \r\n set Titulo = '" + nombre + "', Descripcion = '" + desc + "'  , Descripcion2 = '" + codigo + "'\r\nWhere IdDestacado = " + id + "");
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
                datos.setearConsulta("delete from Destacados where IdDestacado = " + codigo);
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


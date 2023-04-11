using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class PreguntaFrecuenteNegocio
    {
        public List<PreguntaFrecuente> ListarFaq()
        {
            List<PreguntaFrecuente> lista = new List<PreguntaFrecuente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Pregunta, Respuesta, IdFaq from faq");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    PreguntaFrecuente aux = new PreguntaFrecuente();
                    aux.Pregunta = (string)datos.Lector["Pregunta"];
                    aux.Respuesta = (string)datos.Lector["Respuesta"];
                    aux.IdPregunta = (int)datos.Lector["IdFaq"];
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

        public void Agregar(string preg, string res)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Faq(Pregunta, Respuesta) values('" + preg + "','" + res +"')");
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

        public void Modificar(string preg, string res, int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Faq \r\n set Pregunta = '" + preg + "', Respuesta = '" + res + "' Where IdFaq = " + id + "");
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
                datos.setearConsulta("delete from FAQ where IdFaq = " + codigo);
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

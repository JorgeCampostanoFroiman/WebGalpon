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
                datos.setearConsulta("select Pregunta, Respuesta from faq");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    PreguntaFrecuente aux = new PreguntaFrecuente();
                    aux.Pregunta = (string)datos.Lector["Pregunta"];
                    aux.Respuesta = (string)datos.Lector["Respuesta"];
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

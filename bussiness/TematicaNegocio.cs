using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class TematicaNegocio
    {
        public List<Tematica> Listar()
        {
            List<Tematica> lista = new List<Tematica>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdTematica, Nombre from Tematicas order by Nombre");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Tematica aux = new Tematica();
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Id = (int)datos.Lector["IdTematica"];
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

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
    }
}

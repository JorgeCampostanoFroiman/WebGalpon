using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class InfoMayoristaNegocio
    {
        public List<InfoMayorista> Listar()
        {
            List<InfoMayorista> lista = new List<InfoMayorista>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Titulo, Descripcion, Descripcion2 from InfoMayorista");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    InfoMayorista aux = new InfoMayorista();
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Descripcion2 = (string)datos.Lector["Descripcion2"];
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

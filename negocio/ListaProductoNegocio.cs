using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    internal class ListaProductoNegocio
    {
        public List<ListaProducto> ListarProductosCompra(int id)
        {
            List<ListaProducto> lista = new List<ListaProducto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ListaProductos.IdProducto, ListaProductos.Cantidad, ListaProductos.Subtotal, Producto.Codigo, Producto.NombreProducto from ListaProductos inner join Producto on ListaProductos.IdProducto = Producto.IdProducto");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    ListaProducto aux = new ListaProducto();
                    aux.ItemArt = new Producto(((int)datos.Lector["IdProducto"]));
                    aux.Cantidad = (int)datos.Lector["Cantidad"];
                    aux.Subtotal = (decimal)datos.Lector["Subtotal"];
                    aux.ItemArt.NombreProducto = (string)datos.Lector["NombreProducto"];
                    aux.ItemArt.Codigo = (string)datos.Lector["Codigo"];
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

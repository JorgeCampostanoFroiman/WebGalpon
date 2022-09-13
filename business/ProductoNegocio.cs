using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using domain;

namespace negocio
{
    internal class ProductoNegocio
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select IdProducto, Codigo, Tipo, NombreProducto, PrecioCompra, Stock, Ganancia, PrecioVenta, Descripcion, ImagenUrl, Estado From Producto");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.IdProducto = (int)datos.Lector["IdProducto"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Tipo = (string)datos.Lector["Tipo"];
                    aux.NombreProducto = (string)datos.Lector["NombreProducto"];
                    aux.PrecioCompra = (decimal)datos.Lector["PrecioCompra"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.Ganancia = ((int)Convert.ToInt64(datos.Lector["Ganancia"]));
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioVenta"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Estado = (int)datos.Lector["Estado"];
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

        //public void Agregar(Producto nuevo)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        string valores = "values('" + nuevo.Codigo + "', '" + nuevo.NombreProducto + "', '" + nuevo.marca.IdMarca + "', '" + nuevo.tipo.IdTipo + "', '" + nuevo.precioCompra + "', " + nuevo.Stock + ", '" + nuevo.Ganancia + "', '" + nuevo.precioVenta + "', '" + nuevo.Descripcion + "', '" + nuevo.proveedor.IdProveedor + "', '" + nuevo.imagenUrl + "', '" + nuevo.estadostock.IdEstadoStockProducto + "')";
        //        datos.setearConsulta("insert into Producto (Codigo, NombreProducto, IdMarca, IdTipo, PrecioCompra, Stock, Ganancia, PrecioVenta, Descripcion,IdProveedor, ImagenUrl, IdEstadoStock ) " + valores);

        //        datos.ejecutarAccion();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        //public void modificar(Producto modificar)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("update Producto set Codigo = @codigo, NombreProducto = @nombre, IdMarca = @idMarca, IdTipo = @idTipo, PrecioCompra = @precioCompra, Stock = @stock, Ganancia = @ganancia, PrecioVenta = @precioVenta, Descripcion = @descripcion, IdProveedor = @idProveedor, IdEstadoStock = @idestadostock WHERE IdProducto = @id");

        //        datos.setearParametro("@codigo", modificar.Codigo);
        //        datos.setearParametro("@nombre", modificar.NombreProducto);
        //        datos.setearParametro("@idMarca", modificar.marca.IdMarca);
        //        datos.setearParametro("@idTipo", modificar.tipo.IdTipo);
        //        datos.setearParametro("@precioCompra", modificar.precioCompra);
        //        datos.setearParametro("@stock", modificar.Stock);
        //        datos.setearParametro("@ganancia", modificar.Ganancia);
        //        datos.setearParametro("@precioVenta", modificar.precioVenta);
        //        datos.setearParametro("@descripcion", modificar.Descripcion);
        //        datos.setearParametro("@idProveedor", modificar.proveedor.IdProveedor);
        //        datos.setearParametro("@idestadostock", modificar.estadostock.IdEstadoStockProducto);

        //        datos.setearParametro("@id", modificar.IdProducto);
        //        datos.ejectutarAccion();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}
        //public void eliminar(int id)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("Update Producto Set Estado = " + 0 + " where IdProducto = " + id);
        //        datos.ejectutarAccion();

        //        /*datos.setearConsulta("Delete From Producto Where IdProducto = " + id);
        //        datos.ejectutarAccion();*/
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //        datos = null;
        //    }
        //}

    }
}

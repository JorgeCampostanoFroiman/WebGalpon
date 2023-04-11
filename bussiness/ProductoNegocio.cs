using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain;

namespace bussiness
{
    public class ProductoNegocio
    {
        public List<Producto> Recomendados(string tipo)
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {


                datos.setearConsulta("SELECT TOP 3 Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = '" + tipo + "' ORDER BY NEWID()");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["Nombre"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioMayorista"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Tipo = (string)datos.Lector["NombreTipo"];
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


        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {


                datos.setearConsulta("select Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Categoria.NombreCategoria, Categoria.IdCategoria, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Tipo on Producto.IdTipo = Tipo.IdTipo inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["Nombre"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioMayorista"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Tipo = (string)datos.Lector["NombreTipo"];
                    aux.Categoria = (string)datos.Lector["NombreCategoria"];
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

        public List<Producto> ListarPopulares()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria, Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.Codigo in ('901R', '902R', '903R', '904R')");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["NombreProducto"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioMayorista"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Tipo = (string)datos.Lector["NombreTipo"];
                    aux.Categoria = (string)datos.Lector["NombreCategoria"];
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

        public List<Producto> ListarPorTipo(string str)
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                switch (str)
                {
                    case "1":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria, Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro Rectangular' or Tipo.NombreTipo = 'Cuadro x6';");
                        break;

                    case "2":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro escalonado';");
                        break;

                    case "3":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro escalonado 2';");
                        break;

                    case "4":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro escalonado 3';");
                        break;

                    case "5":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro poliptico';");
                        break;

                    case "6":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro triptico';");
                        break;

                    case "7":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro x6';");
                        break;
                    case "8":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Portallave';");
                        break;
                    case "9":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Perchero';");
                        break;
                    case "10":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Reloj 32';");
                        break;
                    case "11":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Individual 2740' or Tipo.NombreTipo = 'Individual 2030' or Tipo.NombreTipo = 'Individual 2760';");
                        break;
                    case "14":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Tablas con frases';");
                        break;
                    case "16":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Bastidor';");
                        break;
                    case "51":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro Rectangular' or Tipo.NombreTipo = 'Cuadro poliptico' or Tipo.NombreTipo = 'Cuadro x6';");
                        break;
                    case "52":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Tipo.NombreTipo = 'Cuadro escalonado' or Tipo.NombreTipo = 'Cuadro escalonado 2' or Tipo.NombreTipo = 'Cuadro escalonado 3';");
                        break;
                    default:
                        break;
                }

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["Nombre"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioMayorista"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Tipo = (string)datos.Lector["NombreTipo"];
                    aux.Categoria = (string)datos.Lector["NombreCategoria"];
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
        public List<Producto> ListarPorCategoria(string str)
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                switch (str)
                {
                    case "1":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.IdCategoria = 1");
                        break;

                    case "2":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.IdCategoria = 2");
                        break;
                    case "3":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.IdCategoria = 3");
                        break;
                    case "4":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.IdCategoria = 4");
                        break;
                    case "5":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.IdCategoria = 5");
                        break;
                    case "6":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.IdCategoria = 6");
                        break;
                    case "7":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.IdCategoria = 7");
                        break;
                    case "8":
                        datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria,Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.IdCategoria = 8");
                        break;
                    default:
                        break;
                }

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["Nombre"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioMayorista"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Tipo = (string)datos.Lector["NombreTipo"];
                    aux.Categoria = (string)datos.Lector["NombreCategoria"];
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


        public List<Producto> Variantes(string codigo)
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Categoria.NombreCategoria, Categoria.IdCategoria, Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Categoria on Producto.IdCategoria = Categoria.IdCategoria inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.Codigo = '" + codigo + "'");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["Nombre"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioMayorista"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Tipo = (string)datos.Lector["NombreTipo"];
                    aux.Categoria = (string)datos.Lector["NombreCategoria"];

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

        public Producto BuscarProducto(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();

            Producto aux = new Producto();


            try
            {
                datos.setearConsulta("select Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.Codigo = '" + codigo + "'");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["Nombre"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioMayorista"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Tipo = (string)datos.Lector["NombreTipo"];
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

        public List<Producto> BuscarUnProducto(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();

            List<Producto> LISTA = new List<Producto>();


            try
            {
                datos.setearConsulta("select Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.Codigo = '" + codigo + "'");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["Nombre"];
                    aux.PrecioVenta = (decimal)datos.Lector["PrecioMayorista"];
                    aux.PrecioMinorista = (decimal)datos.Lector["PrecioMinorista"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Tipo = (string)datos.Lector["NombreTipo"];
                }
                return LISTA;
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

        public bool ExisteProducto(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();

            Producto aux = new Producto();


            try
            {
                datos.setearConsulta("select Tipo.NombreTipo, Tipo.Descripcion, Tipo.PrecioMinorista, Tipo.PrecioMayorista, Producto.Codigo, Producto.Nombre, Producto.Estado, Producto.ImagenUrl from Producto inner join Tipo on Producto.IdTipo = Tipo.IdTipo where Producto.Codigo = '" + codigo + "'");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    if ((string)datos.Lector["Codigo"] != null)
                    {
                        return true;
                    }
                }
                return false; 
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

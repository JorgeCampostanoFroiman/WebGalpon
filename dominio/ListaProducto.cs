using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ListaProducto
    {
        public int IdListaProducto { get; set; }
        public int Cantidad { get; set; }
        public Producto ItemArt { get; set; }
        public decimal Subtotal { get; set; }
        public int IdNumeroDeCompra { get; set; }
        public int IdNumeroDeVenta { get; set; }
        public ListaProducto(int id, Producto product, int cant, decimal st, bool transaccion, int idproducto, int numerocompra)
        {
            IdListaProducto = id;
            ItemArt = product;
            Cantidad = cant;
            Subtotal = st;
            IdNumeroDeCompra = numerocompra;
        }
        public ListaProducto(int id)
        {
            IdListaProducto = id;
        }

        public ListaProducto() { }
    }
}

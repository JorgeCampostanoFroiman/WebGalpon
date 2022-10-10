using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioMinorista { get; set; }
        public int Stock { get; set; }
        public int Ganancia { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public int Estado { get; set; }



        public Producto(int id)
        {
            IdProducto = id;
        }

        public Producto()
        {

        }
    }
}

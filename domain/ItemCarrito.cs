using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class ItemCarrito
    {
        public int Cantidad { get; set; }
        public Producto ItemArt { get; set; }
        public decimal Subtotal { get; set; }

        public ItemCarrito()
        {

        }
    }
}

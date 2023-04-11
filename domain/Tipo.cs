using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioMayorista { get; set; }
        public decimal PrecioMinorista { get; set; }

        public Tipo(int id)
        {
            Id = id;
        }

        public Tipo()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Destacado
    {
        public int IdDestacado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }

        public Destacado(int id)
        {
            IdDestacado = id;
        }

        public Destacado()
        {

        }
    }
}

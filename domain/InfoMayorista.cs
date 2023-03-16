using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class InfoMayorista
    {
        public int IdInfo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public string Descripcion2 { get; set; }

        public InfoMayorista(int id)
        {
            IdInfo = id;
        }

        public InfoMayorista()
        {

        }
    }
}

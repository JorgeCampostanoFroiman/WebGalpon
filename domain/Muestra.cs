using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Muestra
    {
        public int IdMuestra { get; set; }
        public string Codigo { get; set; }
        public string ImagenUrl { get; set; }


        public Muestra(int id)
        {
            IdMuestra = id;
        }

        public Muestra()
        {

        }
    }


}

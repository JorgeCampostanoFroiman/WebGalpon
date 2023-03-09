using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    internal class Novedad
    {
        public int IdNovedad { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }

        public Novedad(int id)
        {
            IdNovedad = id;
        }

        public Novedad()
        {

        }
    }
}

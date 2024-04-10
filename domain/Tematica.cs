using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Tematica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Tematica(int id)
        {
            Id = id;
        }

        public Tematica()
        {

        }
    }
}

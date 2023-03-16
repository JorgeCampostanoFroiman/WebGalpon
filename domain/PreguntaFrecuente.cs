using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class PreguntaFrecuente
    {
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }

        public PreguntaFrecuente(int id)
        {
            IdPregunta = id;
        }

        public PreguntaFrecuente()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public enum TipoUsuario
    {
        ADMIN = 1,
        NORMAL = 2
    }

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int Dni { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public Usuario(string pass, string nombreUsuario, bool admin)
        {
            Contraseña = pass;
            NombreUsuario = nombreUsuario;
            TipoUsuario = admin ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
        }

        public Usuario(string mail)
        {
            Email = mail;
        }
        public Usuario()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.models
{
    public class User
    {
        public User() { }

        public User(string usuario, string password, string nombre)
        {
            Usuario = usuario;
            Password = password;
            Nombre = nombre;
        }

        public int Id_usuario { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
    }
}

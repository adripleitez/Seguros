using Seguros.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros.Controllers
{
    class UserController
    {
        private static segurosEntities db = new segurosEntities();

        public static void registrarUsuario(string nombre, string password, string user)
        {
            try
            {
                usuario unUsuario = new usuario();
                unUsuario.username = user;
                unUsuario.nombre = nombre;
                unUsuario.password = password;

                db.usuario.Add(unUsuario);
                db.SaveChanges();

            }
            catch (Exception)
            {

                throw new Exception("Algo anda mal");
            }

        }

    }
}

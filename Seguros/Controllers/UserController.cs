using MySqlConnector;
using Seguros.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Controllers
{
    class UserController
    {
        private static MySqlCommand sql = new MySqlCommand();
        public static void RegisterUser(User newUser)
        {
            sql.CommandText="INSERT INTO usuario (usuario, password, nombre) VALUES (@usuario, @password, @nombre)";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("usuario",newUser.Usuario);
            sql.Parameters.AddWithValue("password",newUser.Password);
            sql.Parameters.AddWithValue("nombre",newUser.Nombre);

            Connection.ExecuteNonQuery(sql);
        }

        public static DataTable GetUserHistorial()
        {
            sql.CommandText = "SELECT * FROM usuario";

            return Connection.ExecuteQuery(sql);
        }
    }
}

using MySqlConnector;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros.Controllers
{
    class Connection
    {
        private static string Host = "127.0.0.1",
            Database = "seguros",
            Port = "3306",
            User = "root",
            Password = "root";

        private static string Cadena = $"Server={Host};Port={Port};User Id={User};Password={Password};Database={Database};";

        private static MySqlConnection conn = new MySqlConnection(Cadena);

        //Aun no probado
        public static DataTable ExecuteQuery(MySqlCommand command)
        {
            DataSet Ds = new DataSet();

            //Conexion a la base de datos

            try
            {
                conn.Open();
                MySqlDataAdapter Da = new MySqlDataAdapter();
                command.Connection = conn;
                Da.SelectCommand = command;
                Da.Fill(Ds);
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se conecto la base de datos");
            }

            
            return Ds.Tables[0];
        }


        public static void ExecuteNonQuery(MySqlCommand command)
        {
            try
            {
                conn.Open();
                command.Connection = conn;
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Operacion realizada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}
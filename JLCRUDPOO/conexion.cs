using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCRUDPOO
{
    class Conexion
    {
        public MySqlConnection conexion()
        {
            string server = "localhost";
            string db = "pnames";
            string user = "root";
            string password = "";
            string connectionString = "Database=" + db + "; Data Source=" + server + "; User Id= " + user + "; Password=" + password + "";
            try
            {
                MySqlConnection conexionDB = new MySqlConnection(connectionString);
                return conexionDB;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}

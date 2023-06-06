using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjemploADONET
{
    internal class DbUtils
    {

        public static MySqlConnection RecuperarNuevaConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["mySqlConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}

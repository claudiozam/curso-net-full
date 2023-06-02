using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleAppEjemploADONET
{
    internal class ManejadorDeArticulos
    {
        public Articulo RecuperarArticuloPorId(int id)
        {

            MySqlConnection connection = null;
            Articulo articulo = null;
            try
            {
                connection = DbUtils.RecuperarNuevaConnection();

                MySqlCommand command = connection.CreateCommand();
                string sqlSelect = "select id_articulo, nombre, precio from articulos where id_articulo = @id;";
                command.CommandText = sqlSelect;

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    articulo = new Articulo();
                    articulo.IdArticulo = reader.GetInt32("id_articulo");
                    articulo.Nombre = reader.GetString("nombre");
                    articulo.Precio = reader.GetDouble("precio");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Hay un error general de Mysql");
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }


            return articulo;
        }
        public void BorrarArticulo(int id)
        {
            string connectionString = "Server=localhost;Database=ejemplo_net;Uid=root;Pwd=root;";

            MySqlConnection connection = null;
            MySqlTransaction transaction = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();
                MySqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                string sqlInsert = "delete from articulos where id_articulo = @id;";

                command.CommandText = sqlInsert;
                command.Parameters.AddWithValue("@id", id);
                int rowCount = command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine("Hay un error general de Mysql");
                Console.WriteLine(e.Message);
                if (transaction != null)
                    transaction.Rollback();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }

        }

        public void AltaDeArticulo(Articulo articulo)
        {
            string connectionString = "Server=localhost;Database=ejemplo_net;Uid=root;Pwd=root;";

            MySqlConnection connection = null;
            MySqlTransaction transaction = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();
                MySqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                string sqlInsert = "insert into articulos (nombre, precio) values (@nombre, @precio);";

                command.CommandText = sqlInsert;
                command.Parameters.AddWithValue("@nombre", articulo.Nombre);
                command.Parameters.AddWithValue("@precio", articulo.Precio);
                int rowCount = command.ExecuteNonQuery();
                transaction.Commit();
 
            }
            catch (Exception e)
            {
                Console.WriteLine("Hay un error general de Mysql");
                Console.WriteLine(e.Message);
                if (transaction != null)
                    transaction.Rollback();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }
        }

        public List<Articulo> RecuperarArticulos()
        {   List<Articulo> articulos = new List<Articulo>();

            string connectionString = "Server=localhost;Database=ejemplo_net;Uid=root;Pwd=root;";

            MySqlConnection connection = null;
            Articulo articulo = null;   
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                string sqlSelect = "select id_articulo, nombre, precio from articulos;";
                command.CommandText = sqlSelect;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    articulo = new Articulo();
                    articulo.IdArticulo = reader.GetInt32("id_articulo");
                    articulo.Nombre = reader.GetString("nombre");
                    articulo.Precio = reader.GetDouble("precio");
                    articulos.Add(articulo);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Hay un error general de Mysql");
                Console.WriteLine(e.Message);
               
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }



            return articulos;
        }
    }
}

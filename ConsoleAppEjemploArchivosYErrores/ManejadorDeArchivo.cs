using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppEjemploArchivosYErrores
{
    internal class ManejadorDeArchivo
    {

        public void LeerDatosCSV(string ruta)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(ruta);
                string linea = sr.ReadLine();
                linea = sr.ReadLine(); //OJO QUE LA PRIMER LINEA LA TENGO QUE IGNORAR!!!
                while (linea != null)
                {
                    string[] datos = linea.Split(';');
                    long id = long.Parse(datos[0]);
                    string nombre = datos[1];
                    string apelledo = datos[2];
                    double sueldo = double.Parse(datos[3]);
                    Console.WriteLine(nombre + " " + apelledo + " " + sueldo);
                    linea = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Error al leer el archivo: " + e.Message);
                throw;
            }
            finally
            {
                try { 
                    if(sr != null ) sr.Close();
                } catch { }
            }
        }
    }
}

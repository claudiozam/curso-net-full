using ConsoleAppEjemploArchivosYErrores;
using System;
using System.IO;

ManejadorDeArchivo manejadorDeArchivo = new ManejadorDeArchivo();
try
{
    manejadorDeArchivo.LeerDatosCSV(@"C:\Users\claud\tmp\empleadosxxx.csv");
} catch(Exception e)
{
    Console.WriteLine("Hay un error: " + e.Message);
}
/*
StreamReader sr = null;
try
{
    sr = new StreamReader(@"C:\Users\claud\tmp\empleadosxxx.csv");
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
    Console.WriteLine("Error al leer el archivo: " + e.Message);
} 
finally
{
    try { sr.Close(); } catch { }
}
*/
Console.WriteLine("Fin del programa");
using ConsoleAppEjemploArchivosYErrores;
using System;
using System.IO;
using log4net;

ILog log = LogManager.GetLogger("Principal.cs");

log.Info("Inicio del programa");


try
{
    log.Debug("Estoy probando el try");
    EjemploErrorPropagado ejemploErrorPropagado = new EjemploErrorPropagado();
    ejemploErrorPropagado.HacerAlgoConError();

}
catch (NullReferenceException e)
{
    log.Error("Hay un error de null", e);
}
catch(Exception e)
{
    log.Error("Hay un error general", e);
}

log.Info("Fin del programa");












/*
ManejadorDeArchivo manejadorDeArchivo = new ManejadorDeArchivo();
try
{
    manejadorDeArchivo.LeerDatosCSV(@"C:\Users\claud\tmp\empleadosxxx.csv");
} catch(Exception e)
{
    Console.WriteLine("Hay un error: " + e.Message);
}*/
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
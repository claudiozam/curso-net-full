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




ManejadorDeArchivo manejadorDeArchivo = new ManejadorDeArchivo();
try
{
    manejadorDeArchivo.LeerDatosCSV(@"C:\Users\claud\tmp\empleadosxxx.csv");
} catch(Exception e)
{
    Console.WriteLine("Hay un error: " + e.Message);
}

log.Info("Fin del programa");

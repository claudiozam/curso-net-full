using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ConsoleAppEjemploArchivosYErrores
{
    internal class EjemploErrorPropagado
    {
        private static readonly ILog log = LogManager.GetLogger("EjemploErrorPropagado.cs");

        public void HacerAlgoConError()
        {
            log.Debug("Ejecutando HacerAlgoConError.....");
            string[] nombres = new string[2];
            nombres[99] = "Pedro";
            string texto = null;

            string textoUpper = texto.ToUpper();
        }
    }
}

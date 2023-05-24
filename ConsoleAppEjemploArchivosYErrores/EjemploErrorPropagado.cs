using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjemploArchivosYErrores
{
    internal class EjemploErrorPropagado
    {

        public void HacerAlgoConError()
        {
            string[] nombres = new string[2];
            nombres[99] = "Pedro";
            string texto = null;

            string textoUpper = texto.ToUpper();
        }
    }
}

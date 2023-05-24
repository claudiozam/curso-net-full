using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjemploArchivosYErrores
{
    internal class MiPropiaException : Exception
    {
        public MiPropiaException() {
        }
        public MiPropiaException(string mensajeDeError) : base(mensajeDeError)
        {

        }

    }
}

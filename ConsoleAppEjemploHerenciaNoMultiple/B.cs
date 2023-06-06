using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjemploHerenciaNoMultiple
{
    internal class B
    {
        private IC c;

        internal IC IC { get => c; set => c = value; }

        public void HacerAlgoEnBConA()
        {
            c.HacerAlgoEnA();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjemploStatic
{
    internal class ContadorGeneral
    {
        public static int contador = 0;

        public void SaludarDeInstancia()
        {
            Console.WriteLine("Soy un ejemplo de metodo static");
        }

        public static void Saludar()
        {
            Console.WriteLine("Soy un ejemplo de metodo static");
        }
    }
}

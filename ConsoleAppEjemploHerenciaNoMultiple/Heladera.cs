using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjemploHerenciaNoMultiple
{
    internal class Heladera : Producto, IElectrodomestico
    {
        public void HacerAlgoConHeladera()
        {
            Console.WriteLine("Ejecutando HacerAlgoConHeladera");
        }

        public void PrenderElectrodomestico()
        {
            //throw new NotImplementedException();
        }
    }
}

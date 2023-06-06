using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    internal class SeguroDelAuto : IProducto
    {
        private double prima;
        private double valor;

        public double Prima { get => prima; set => prima = value; }
        public double Valor { get => valor; set => valor = value; }

        public double RecuperarElPrecio()
        {
            return 20000;
        }

        public void Vender()
        {
            Console.WriteLine("Listo vendio el seguro del auto..");
        }
    }
}

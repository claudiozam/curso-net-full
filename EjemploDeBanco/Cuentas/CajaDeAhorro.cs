using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    internal class CajaDeAhorro : CuentaBancaria, IProducto
    {
        public CajaDeAhorro(long numeroDecuenta, double saldo) : base(numeroDecuenta, saldo)
        {

        }

        public override void Extraer(double monto)
        {
            if(base.Saldo - monto >= 0)
            {
                base.Saldo = base.Saldo - monto;

            } else
            {
                Console.WriteLine("Me suena que no tenes tanta plata.....");
            }
        }

        public double RecuperarElPrecio()
        {
            return 10000;
        }

        public void Vender()
        {
            Console.WriteLine("Listo vendio la caja de ahorro..");
        }

    }
}

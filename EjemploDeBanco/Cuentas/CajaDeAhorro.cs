using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    internal class CajaDeAhorro : CuentaBancaria
    {
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    internal class CuentaSueldo : CuentaBancaria
    {
        public CuentaSueldo(long numeroDecuenta, double saldo) : base(numeroDecuenta, saldo)
        {
        }

        public override void Extraer(double monto)
        {
            throw new NotImplementedException();
        }
    }
}

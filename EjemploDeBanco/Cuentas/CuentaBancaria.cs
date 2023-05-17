using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    internal abstract class CuentaBancaria
    {
        private long numeroDecuenta;
        private double saldo;

        public long NumeroDecuenta { get => numeroDecuenta; set => numeroDecuenta = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public abstract void Extraer(double monto);
        /*{
            Console.WriteLine("Ejecutando Extraer de la CuentaBancaria " + NumeroDecuenta);
            saldo = saldo - monto;
        }*/
    }
}

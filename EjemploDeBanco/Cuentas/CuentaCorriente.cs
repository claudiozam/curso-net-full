using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    internal class CuentaCorriente : CuentaBancaria, IProducto
    {
        private double limiteExtra = 10000;


        public double RecuperarElPrecio()
        {
            return 15000;
        }

        public void Vender()
        {
            Console.WriteLine("Listo vendio la cuenta corriente..");
        }

        public CuentaCorriente(long numeroDecuenta, double saldo, double limiteExtra) : base(numeroDecuenta, saldo)
        {
            this.limiteExtra = limiteExtra;
        }

        public double LimiteExtra { get => limiteExtra; set => limiteExtra = value; }

        public override void Extraer(double monto)
        {
            if ((base.Saldo + limiteExtra) - monto >= 0)
            {
                base.Saldo = base.Saldo - monto;

            }
            else
            {
                Console.WriteLine("Me suena que no tenes tanta plata.....");
            }
        }
    }
}

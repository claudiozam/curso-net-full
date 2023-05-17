using EjemploDeBanco.Cuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco
{
    internal class Banco
    {
        public void ExtraerDineroDeCuentaBancaria(CuentaBancaria cuenta, double monto)
        {
            Type tipoDeClase = cuenta.GetType();
            Console.WriteLine(tipoDeClase.Name);
            cuenta.Extraer(monto); //POLIMORFISMO!!!!!!
        }

    }
}

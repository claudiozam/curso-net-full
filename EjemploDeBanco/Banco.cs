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

        public void VenderProducto(IProducto producto)
        {
            Type tipoDeClase = producto.GetType();
            Console.WriteLine(tipoDeClase.Name);
            producto.Vender();
            Console.WriteLine("Precio: " + producto.RecuperarElPrecio());
   
        }

        public void ExtraerDineroDeCuentaBancaria(CuentaBancaria cuenta, double monto)
        {
            Type tipoDeClase = cuenta.GetType();
            Console.WriteLine(tipoDeClase.Name);
            cuenta.Extraer(monto); //POLIMORFISMO!!!!!!
        }

        public void ExtraerDineroDeCuentaBancaria(CuentaBancaria cuenta, double monto, double impuestos)
        {
            this.ExtraerDineroDeCuentaBancaria(cuenta, monto +impuestos);
            /*Type tipoDeClase = cuenta.GetType();
            Console.WriteLine(tipoDeClase.Name);
            cuenta.Extraer(monto + impuestos); //POLIMORFISMO!!!!!!*/
        }
    }
}

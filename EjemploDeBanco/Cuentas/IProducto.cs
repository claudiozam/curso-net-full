using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeBanco.Cuentas
{
    internal interface IProducto
    {
        public void Vender();
        public double RecuperarElPrecio();
    }
}

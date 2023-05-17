// See https://aka.ms/new-console-template for more information
using EjemploDeBanco;
using EjemploDeBanco.Cuentas;


Banco banco = new Banco(); 

CuentaCorriente cuentaCorriente1 = new CuentaCorriente(1001, 5000, 1500);
//cuentaCorriente1.NumeroDecuenta = 1001;
//cuentaCorriente1.Saldo = 5000;

banco.ExtraerDineroDeCuentaBancaria(cuentaCorriente1, 6000);

Console.WriteLine(cuentaCorriente1.Saldo);

CajaDeAhorro cajaDeAhorro1 = new CajaDeAhorro(1002, 3000);
//cajaDeAhorro1.NumeroDecuenta = 1002;
//cajaDeAhorro1.Saldo = 3000;

banco.ExtraerDineroDeCuentaBancaria(cajaDeAhorro1, 1000);

Console.WriteLine(cajaDeAhorro1.Saldo);


Cliente cliente1 = new Cliente(5001, "Juan", "Perez");

Console.WriteLine(cliente1);
Cliente cliente2 = new Cliente(5002, "Maria", "Lopez");


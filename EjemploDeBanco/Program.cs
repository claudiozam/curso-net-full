// See https://aka.ms/new-console-template for more information
using EjemploDeBanco.Cuentas;

Console.WriteLine("Hello, World!");
CuentaBancaria cuentaBancaria1 = new CuentaBancaria();
cuentaBancaria1.NumeroDecuenta = 1001;
cuentaBancaria1.Saldo = 10000;
cuentaBancaria1.Extraer(5000);
Console.WriteLine(cuentaBancaria1.Saldo);

CuentaCorriente cuentaCorriente1 = new CuentaCorriente();
CajaDeAhorro cajaDeAhorro1 = new CajaDeAhorro();
cajaDeAhorro1.NumeroDecuenta = 1002;
cajaDeAhorro1.Saldo = 3000;
cajaDeAhorro1.Extraer(9000);
Console.WriteLine(cajaDeAhorro1.Saldo);

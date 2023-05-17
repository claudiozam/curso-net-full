// See https://aka.ms/new-console-template for more information
using EjemploDeBanco;
using EjemploDeBanco.Cuentas;


Banco banco = new Banco(); 

CuentaCorriente cuentaCorriente1 = new CuentaCorriente();
cuentaCorriente1.NumeroDecuenta = 1001;
cuentaCorriente1.Saldo = 5000;

banco.ExtraerDineroDeCuentaBancaria(cuentaCorriente1, 6000);

Console.WriteLine(cuentaCorriente1.Saldo);

CajaDeAhorro cajaDeAhorro1 = new CajaDeAhorro();
cajaDeAhorro1.NumeroDecuenta = 1002;
cajaDeAhorro1.Saldo = 3000;

banco.ExtraerDineroDeCuentaBancaria(cajaDeAhorro1, 1000);

Console.WriteLine(cajaDeAhorro1.Saldo);

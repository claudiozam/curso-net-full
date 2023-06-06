// See https://aka.ms/new-console-template for more information
using ConsoleAppEjemploHerenciaNoMultiple;
using System.Collections;

Console.WriteLine("Hello, World!");

Heladera heladera = new Heladera();

Producto producto = new Producto();

//IElectrodomestico electrodomestico = new IElectrodomestico();

//List<string> lista = new List<string>();

ICollection<string> lista = new List<string>();
ICollection<string> listaSinRepetidos = new HashSet<string>();



//B --> C ---> A

A a = new A();
B b = new B();
b.IC = a;

b.HacerAlgoEnBConA();
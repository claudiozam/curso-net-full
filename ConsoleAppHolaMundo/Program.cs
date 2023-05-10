using ConsoleAppHolaMundo;

Console.WriteLine("Ingresar el 1er numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar el 2do numero");
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar la operacion 'sumar - restar - mutiplicar - dividir'");
string operacion = Console.ReadLine();
int total = 0;

Calculadora calculadora1 = new Calculadora();

switch(operacion)
{
    case "sumar":
        total = calculadora1.Sumar(numero1, numero2);
        break;

    case "restar":
        total = numero1 - numero2;
        break;

    default:
        Console.WriteLine("No tengo esa operacion programada...");
        break;

}
Console.WriteLine("El total es " + total);
//Console.ReadLine();
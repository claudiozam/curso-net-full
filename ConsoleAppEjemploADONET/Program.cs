
using ConsoleAppEjemploADONET;

ManejadorDeArticulos manejadorDeArticulos = new ManejadorDeArticulos();
Articulo articulo = new Articulo();
articulo.Nombre = "Nuevo ejemplo";
articulo.Precio = 4000;

manejadorDeArticulos.AltaDeArticulo(articulo);

List<Articulo> articulos = manejadorDeArticulos.RecuperarArticulos();
foreach(Articulo a in articulos)
{
    Console.WriteLine(a.Nombre); 
    Console.WriteLine(a.Precio);
    Console.WriteLine("**************************");
}
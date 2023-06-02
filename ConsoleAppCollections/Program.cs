using ConsoleAppCollections;

List<Persona> personas = new List<Persona>();
personas.Add(new Persona(1, "Juan", "Perez"));
personas.Add(new Persona(2, "Pedro", "Orlando"));
personas.Add(new Persona(3, "Maria", "Lopez"));

foreach (Persona persona in personas)
{
    Console.WriteLine(persona.Id);
    Console.WriteLine(persona.Nombre);
    Console.WriteLine(persona.Apellido);

}
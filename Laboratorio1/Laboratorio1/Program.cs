using Laboratorio1.Entidades;
using Laboratorio1.Negocio;



ClsPersona Clspersona = new ClsPersona();
Persona persona = new Persona();


Console.WriteLine("Ingrese su Nombre: ");
persona.nombre = (Console.ReadLine());


Console.WriteLine("Ingrese su edad: ");
persona.edad = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese su Sexo: ");
persona.sexo = (Console.ReadLine());


Console.WriteLine("Ingrese su Peso: ");
persona.peso = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese su Altura: ");
persona.altura = Convert.ToDouble(Console.ReadLine());


Clspersona.PesodePersonas(persona);

foreach (var mostrar in Clspersona.ListadoDePeso())
{
    Console.WriteLine($"Nombre: {mostrar.nombre} edad: {mostrar.edad} Sexo: {mostrar.sexo} Peso: {mostrar.peso} altura: {mostrar.altura}");
}

Clspersona.MayordeEdad(persona);

foreach (var mostrar in Clspersona.ListadoDeEdad())
{
 
}





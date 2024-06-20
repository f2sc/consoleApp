using Humanizer;
using System.Globalization;

Console.WriteLine($"Bienvenido al año  {DateTime.Now.Year.ToWords(new CultureInfo("es"))} o como se diría en Portugués: {DateTime.Now.Year.ToWords(new CultureInfo("pt"))}");

Console.WriteLine("Por favor ingrese un nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese su cargo");
string cargo = Console.ReadLine();

Console.WriteLine("Por favor ingrese su edad");
int edad = int.Parse( Console.ReadLine());

Console.WriteLine($"Hola buenas tardes! Mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords(new CultureInfo("cn"))} años.");


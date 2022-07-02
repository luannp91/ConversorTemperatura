using System;

namespace ConversorDeTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### Conversor De Temperaturas ###");
            Console.Write("Insira a Temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            f = (c * 9 / 5) + 32;

            k = c + 273.15;

            Console.WriteLine(c + " graus celcius = " + f + " graus fahrenheit");
            Console.WriteLine(c + " graus celcius = " + k + " graus kelvin");
            Console.WriteLine("---------------------------------");
            Console.ReadKey();
        }
    }
}

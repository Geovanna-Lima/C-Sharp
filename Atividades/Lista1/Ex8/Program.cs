using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            double k;

            Console.WriteLine("Escreva uma temperatura em graus Kelvin:");

            k = float.Parse(Console.ReadLine());

            c = k - 273.15;

            Console.WriteLine("A temperatura em Celsius é: " + c + "°C");
        }
    }
}

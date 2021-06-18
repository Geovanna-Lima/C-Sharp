using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            float c;
            float f;

            Console.WriteLine("Escreva uma temperatura em graus Fahrenheit:");

            f = float.Parse(Console.ReadLine());

            c = 5 * (f - 32) / 9;

            Console.WriteLine("A temperatura em Celsius é: " + c + "°C");
        }
    }
}

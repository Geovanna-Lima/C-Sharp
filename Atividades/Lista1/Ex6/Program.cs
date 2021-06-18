using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            float c;
            float f;

            Console.WriteLine("Escreva uma temperatura em graus Celsius:");

            c = float.Parse(Console.ReadLine());

            f = c * (9 / 5) + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: " + f +"°F");
        }
    }
}

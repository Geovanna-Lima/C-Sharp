using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 9;

            if (a == b)
                Console.WriteLine("Os valores são iguais");

            else
                Console.WriteLine("Os valores são diferentes");


            int x = 7, y = 7;

            if (x != y)
                Console.WriteLine("Os valores são diferentes");

            else
                Console.WriteLine("Os valores são iguais");


            int w = 10, z = 5;
            if (w > z)
                Console.WriteLine("O primeiro valor é maior que o segundo");

            else
                Console.WriteLine("O primeiro valor é menor ou igual ao segundo valor");
        }
    }
}

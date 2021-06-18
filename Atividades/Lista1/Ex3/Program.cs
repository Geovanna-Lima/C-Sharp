using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int soma;

            Console.WriteLine("Entre com o primeiro valor:");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo valor:");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o terceiro valor:");

            c = int.Parse(Console.ReadLine());

            soma = a + b + c;

            Console.WriteLine("A soma desses valores é: " +soma);
        }
    }
}

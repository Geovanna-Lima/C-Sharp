using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Entre com um número:" );
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("O número digitado foi " + numero);
        }
    }
}

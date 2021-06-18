using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double resultado;

            Console.WriteLine("Entre com um número:");

            numero = double.Parse(Console.ReadLine());

            resultado = Math.Pow(numero, 2);

            Console.WriteLine("Esse valor ao quadrado é:" + resultado);

        }
    }
}

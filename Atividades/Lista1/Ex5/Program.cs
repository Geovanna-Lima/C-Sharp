using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            float resultado;

            Console.WriteLine("Entre com um número:");

            numero = float.Parse(Console.ReadLine());

            resultado = numero / 5;

            Console.WriteLine("A quita parte desse valor é: " + resultado);
        }
    }
}

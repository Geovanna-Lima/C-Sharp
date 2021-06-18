using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;

            Console.WriteLine("Digite um número real:"); 

            numero = float.Parse(Console.ReadLine());

            Console.WriteLine("O número digitado foi: " + numero);
        }
    }
}

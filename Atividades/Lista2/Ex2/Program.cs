using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double resultado;

            Console.WriteLine("Entre com um número inteiro:");

            num1 = double.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                resultado = Math.Pow(num1, 2);

                Console.WriteLine("O número digitado ao quadrado é: " + resultado);

                resultado = Math.Sqrt(num1);

                Console.WriteLine("A raíz do número digitado é: " + resultado);
            }
                
            else
                Console.WriteLine("O número digitado foi: " + num1);

        }
    }
}

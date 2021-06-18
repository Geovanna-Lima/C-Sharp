using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int soma = 0;

            Console.WriteLine("Entre com um número inteiro maior que zero:");

            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                while ( num > 0)
                {

                    soma += num % 10;

                    num /= 10;
        
                }
                Console.WriteLine("A soma dos algorismos desse valor é:" + soma);
            }
            else
                Console.WriteLine("Número Inválido!");
        }
    }
}

using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int resp;

            Console.WriteLine("Entre com um número inteiro positivo par: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0 && ((num % 2) == 0))
            {
                for (int i = 0; i <= num; i++)
                {
                    if (i % 2 == 0) 
                        Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Número Inválido!");
        }
    }
}

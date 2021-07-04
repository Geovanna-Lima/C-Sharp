using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Entre um número inteiro:");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Os " + num + " primeiros números ímpares são:");

                for (int i = 1; i <= num + num; i++)
                {
                    if (i % 2 != 0)
                    Console.WriteLine(i);
                }  
            }
            else
                Console.WriteLine("Número Inválido!");
        }
    }
}

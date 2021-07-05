using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int maior = 0;
            int menor = 0;
            int x = 0;

            Console.WriteLine("Entre com números inteiros positivos: ");

            do
            {
                num = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    maior = num;
                    menor = num;
                    x++;
                }
             
                if (num < 0)
                {
                    break;
                } 
                else if (num > maior)
                    maior = num;
                else if (num < menor)
                    menor = num;
            } while (num > 0);

            Console.WriteLine("O maior número é:" + maior);
            Console.WriteLine("O menor número é:" + menor);
        }
    }
}

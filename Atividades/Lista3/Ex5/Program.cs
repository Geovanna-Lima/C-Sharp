using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int mult = 0;

            Console.WriteLine("Entre com um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            for (int i = num + 1; mult == 0; i++)
            {
                mult = (i % 11 == 0) || (i % 13 == 0) || (i % 17 == 0) ? i : 0;
            }
            Console.WriteLine("O primeiro número primo múltiplo de 11, 13 ou 17 é: " + mult);
        }
    }
}

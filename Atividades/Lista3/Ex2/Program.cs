using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 até 100 usando for:");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("1 até 100 usando while:");

            int j = 1;
            
            while (j <= 100)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("1 até 100 usando do while:");

            int x = 1;

            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 100);
        }
    }
}

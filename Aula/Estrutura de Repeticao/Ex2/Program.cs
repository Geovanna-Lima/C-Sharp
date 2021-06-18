using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;


            do
            {
                Console.WriteLine("O valor do contador é " + cont);
                cont++;
            } while (cont < 5);
        }
    }
}

using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elementos = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int x in elementos)
                Console.WriteLine("O valor do elemento é " + x);
        }
    }
}

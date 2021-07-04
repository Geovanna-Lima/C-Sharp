using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            Console.WriteLine("Os cinco múltiplos de três são: ");

            for (int i = 1; i <= 5; i++) {
                result = 3 * i;
                Console.WriteLine("3 X " + i + " = " + result);
            }
        }
    }
}

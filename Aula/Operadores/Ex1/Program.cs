using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 7, b = 9;
            double result;

            result = a + b;
            Console.WriteLine("A soma dos números " +a +" e " +b +" é:" +result);

            result = a - b;
            Console.WriteLine("A subtração dos números " + a + " e " + b + " é:" + result);

            result = a * b;
            Console.WriteLine("A multiplicação dos números " + a + " e " + b + " é:" + result);

            result = a / b;
            Console.WriteLine("A divisão dos números " + a + " e " + b + " é:" + result);

            result = a % b;
            Console.WriteLine("O resto da divisão dos números " + a + " e " + b + " é:" + result);
        }
    }
}

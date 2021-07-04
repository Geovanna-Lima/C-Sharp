using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int num;

            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine("Entre com o " +i +"° número:");
                num = int.Parse(Console.ReadLine());
                result += num; 
            }
            Console.WriteLine("A soma dos números digitados é: " + result);
        }
    }
}

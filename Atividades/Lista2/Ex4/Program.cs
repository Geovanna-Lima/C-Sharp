using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int diferenca;

            Console.WriteLine("Entre com um número inteiro:");

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um número inteiro:");

            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                diferenca = num1 - num2; 

                Console.WriteLine("O número " + num1 + " é maior que o número " + num2);

                Console.WriteLine("A diferença entre o número " + num1 + " e o número " + num2 + " é de:" +diferenca);

            }
            else
            {
                diferenca = num2 - num1;

                Console.WriteLine("O número " + num2 + " é maior que o número " + num1);

                Console.WriteLine("A diferença entre o número " + num1 + " e o número " + num2 + "é de:" + diferenca);

            }
        }
    }
}

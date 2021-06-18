using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double media;

            Console.WriteLine("Entre com a primeira nota:");

            nota1 = double.Parse(Console.ReadLine());

            if (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("Nota Inválida!");
            }
            else
            {
                Console.WriteLine("Entre com a segunda nota:");

                nota2 = double.Parse(Console.ReadLine());

                if (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("Nota Inválida!");
                }
                else
                {
                    media = (nota1 + nota2) / 2;

                    Console.WriteLine("A média do aluno foi: " + media);
                }
            }
        }
    }
}

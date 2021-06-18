using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            float baseMenor;
            float baseMaior;
            float altura;
            float trapezio;

            Console.WriteLine("Entre com a Base Menor do trapézio:");

            baseMenor = float.Parse(Console.ReadLine());

            if (baseMenor > 0)
            {
                Console.WriteLine("Entre com a Base Maior do trapézio:");

                baseMaior = float.Parse(Console.ReadLine());

                if (baseMaior > 0)
                {
                    Console.WriteLine("Entre com a Altura do trapézio:");

                    altura = float.Parse(Console.ReadLine());

                    if (altura > 0)
                    {
                        trapezio = ((baseMenor + baseMaior) * altura) / 2;

                        Console.WriteLine("A área do Trapézio é: " + trapezio);
                    }
                    else
                        Console.WriteLine("Número Inválido!");
                }
                else
                    Console.WriteLine("Número Inválido!");
            }
            else
                Console.WriteLine("Número Inválido!");
        }
    }
}

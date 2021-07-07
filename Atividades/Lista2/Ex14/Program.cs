using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float c;

            Console.WriteLine("Entre com o valor do primeiro lado do triângulo:");

            a = float.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Entre com o valor do segundo lado do triângulo:");

                b = float.Parse(Console.ReadLine());

                if (b > 0)
                {
                    Console.WriteLine("Entre com o valor do terceiro lado do triângulo:");

                    c = float.Parse(Console.ReadLine());

                    if (c > 0)
                    {
                        if (a < (b + c) || b < (a + c) || c < (a + b))
                        {
                            if (a == b && b == c && c == a)
                                Console.WriteLine("Triâgulo Equilátero");

                            else if (a == b || b == c || c == a)
                                Console.WriteLine("Triâgulo Isóceles");

                            else if (a != b && b != c && c != a)
                                Console.WriteLine("Triâgulo Escaleno");
                        }
                        else
                            Console.WriteLine("Não é um Triângulo!");
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

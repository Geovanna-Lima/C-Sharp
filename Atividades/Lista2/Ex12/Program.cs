using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            byte semana;

            Console.WriteLine("Entre com um número de 1 até 7:");

            semana = byte.Parse(Console.ReadLine());

            switch (semana)
            {
                case 1:
                    Console.WriteLine("Esse número corresponde: Segunda-Feira");
                    break;
                case 2:
                    Console.WriteLine("Esse número corresponde: Terça-Feira");
                    break;
                case 3:
                    Console.WriteLine("Esse número corresponde: Quarta-Feira");
                    break;
                case 4:
                    Console.WriteLine("Esse número corresponde: Quinta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Esse número corresponde: Sexta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Esse número corresponde: Sábado");
                    break;
                case 7:
                    Console.WriteLine("Esse número corresponde: Domingo");
                    break;
                default:
                    Console.WriteLine("Número Inválido!");
                    break;
            }
        }
    }
}

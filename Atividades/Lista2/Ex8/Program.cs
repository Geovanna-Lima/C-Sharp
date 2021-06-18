using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sexo;
            double h;
            double peso;

            Console.WriteLine("Entre com a altura da pessoa:");

            h = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o sexo da pessoa 1-Feminino e 2-Masculino:");

            sexo = byte.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                peso = (62.1 * h) - 44.7;

                Console.WriteLine("O seu peso ideal é: " + Math.Round(peso, 2));
            }
            else if (sexo == 2 )
            {
                peso = (72.7 * h) - 58;

                Console.WriteLine("O seu peso ideal é: " + Math.Round(peso, 2));
            }
            else
            {
                Console.WriteLine("Número Inválido!");
            }
        }
    }
}

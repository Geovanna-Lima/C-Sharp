using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            float prova1;
            float prova2;
            float prova3;
            float media;

            Console.WriteLine("Entre com a nota da primeira prova:");

            prova1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota da segunda prova:");

            prova2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota da terceira prova:");

            prova3 = float.Parse(Console.ReadLine());

            media = (((prova1 * 1) + (prova2 * 1) + (prova3 * 2)) / 4) * 10;

            if (media >= 60)
            {
                Console.WriteLine("A média do aluno foi:" + media);
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("A média do aluno foi:" + media);
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}

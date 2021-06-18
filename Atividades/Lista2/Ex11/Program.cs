using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            float trab;
            float avaliacao;
            float exame;
            float media;

            Console.WriteLine("Entre com a nota do trabalho de laboratório:");

            trab = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota da avaliação semestral:");

            avaliacao = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota do exame final:");

            exame = float.Parse(Console.ReadLine());

            media = ((trab * 2) + (avaliacao * 3) + (exame * 5))/ 10;

            if (media >= 0 && media <= 2.9)
            {
                Console.WriteLine("Aluno reprovado!");
            }
            else if (media >= 3.0 && media <= 4.9)
            {
                Console.WriteLine("Aluno está de recuperação!");
            }
            else if (media >= 5 && media <= 10)
            {
                Console.WriteLine("Aluno aprovado!");
            }
        }
    }
}

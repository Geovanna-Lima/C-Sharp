using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] dados_alunos = new string[3, 4];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Lendo informações do " + (i + 1) + "º aluno:");

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Digite dados [" + i + ", " + j +"]: ");
                    dados_alunos[i, j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Os dados do " + (i + 1) + "º aluno são:" + dados_alunos[i, j]);
                }
            }
        }
    }
}

using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            string[,] dados_alunos = new string[3, 2];
            dados_alunos[0, 0] = "João";
            dados_alunos[0, 1] = "joao@gmail.com";
            dados_alunos[1, 0] = "Maria";
            dados_alunos[1, 1] = "maria@gmail.com";
            dados_alunos[2, 0] = "Carlos";
            dados_alunos[2, 1] = "carlos@gmail.com";

            for (i = 0; i < 3; i ++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine(dados_alunos[i, j]);
                }
            }      
        }
    }
}

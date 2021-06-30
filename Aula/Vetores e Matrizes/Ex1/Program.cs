using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[5];
            alunos[0] = "João";
            alunos[1] = "Maria";
            alunos[2] = "Pedro";
            alunos[3] = "Ana";
            alunos[4] = "Carlos";

            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine(alunos[i]);
            }
           
        }
    }
}

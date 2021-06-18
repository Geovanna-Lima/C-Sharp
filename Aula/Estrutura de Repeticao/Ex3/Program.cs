using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte 1
            for (int cont = 0; cont < 10; cont++)
                Console.WriteLine("O contador vale " + cont);

            //Parte 2
            string[,] vetor = new string[2, 2];
            vetor[0, 0] = "A";
            vetor[0, 1] = "B";
            vetor[1, 0] = "C";
            vetor[1, 1] = "D";

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine("O elemento da posição (" + i + ", " + j + ") é " + vetor[i, j]);
        }
    }
}

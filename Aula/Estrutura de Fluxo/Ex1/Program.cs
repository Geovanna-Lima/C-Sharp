using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double prova1 = 7;
            double prova2 = 5;
            double media = 0;
            string desempenho;

            media = (prova1 + prova2) / 2;

            if (media <= 5)
                desempenho = "INSATISFATÓRIO";
            else if (media <= 7)
                desempenho = "REGULAR";
            else if (media <= 8.5)
                desempenho = "BOM";
            else
                desempenho = "ÓTIMO";

            Console.WriteLine("O desempenho do aluno foi " + desempenho);
        }
    }
}

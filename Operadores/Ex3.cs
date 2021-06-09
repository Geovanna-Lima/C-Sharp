using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int media = 9, presenca = 90;
            if((media >= 6) && (presenca >=75))
                Console.WriteLine("O aluno foi aprovado!");
            else
                Console.WriteLine("O aluno foi reprovado!");


            string nota = "ruim";
            if ((nota == "exelente") || (nota == "ótimo") || (nota == "bom"))
                Console.WriteLine("O aluno foi aprovado!");
            else
                Console.WriteLine("O aluno foi reprovado!");


            string situacao = "reprovado";
            if (!(situacao == "aprovado"))
                Console.WriteLine("O aluno foi reprovado!");
            else
                Console.WriteLine("O aluno foi aprovado!");
        }
    }
}

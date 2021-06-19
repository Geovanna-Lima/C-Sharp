using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade;
            byte tempoServico;

            Console.WriteLine("Qual a sua idade?");

            idade = byte.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu tempo de serviço?");

            tempoServico = byte.Parse(Console.ReadLine());

            if (idade >= 65 || tempoServico >= 30 || (idade >= 60 && tempoServico >= 25))
                Console.WriteLine("Você pode se aposentar!");
            else
                Console.WriteLine("Você ainda não pode se aposentar!");
        }
    }
}

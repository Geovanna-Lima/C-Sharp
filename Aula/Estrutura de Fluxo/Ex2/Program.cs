using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "sim";

            switch(opcao)
            {
                case "sim":
                    Console.WriteLine("Você escolheu a opção SIM");
                    break;
                case "não":
                case "talvez":
                    Console.WriteLine("Você não escolheo a opção SIM");
                    break;
                default:
                    Console.WriteLine("A opção digitada é inválida!");
                    break;
            }
        }
    }
}

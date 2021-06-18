using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double prestacao;
            double valor;

            Console.WriteLine("Entre com o valor do seu salário:");

            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor da prestação do seu empréstimo:");

            prestacao = double.Parse(Console.ReadLine());

            valor = salario * 0.2;

            if (prestacao > valor)
                Console.WriteLine("Empréstimo não concedido");
            else
                Console.WriteLine("Empréstimo concedido");
        }
    }
}

using System;

namespace Ex1
{
    class TesteEx1
    {
        static void Main(string[] args)
        {
            Escola e1 = new Escola();
            Endereco end1 = new Endereco();

            end1.setRua("Rua Pedro Vicente");
            end1.setNumero(625);
            end1.setBairro("Canindé");
            end1.setCep("00000-000");
            end1.setCidade("São Paulo");

            e1.setNome("IFSP");
            e1.setAnoFundacao(2008);
            e1.setMediaEnem(850.00f);
            e1.setEndereco(end1);

            Console.WriteLine("Informações da Escola:");
            Console.WriteLine("Nome: " + e1.getNome());
            Console.WriteLine("Ano fundação: " + e1.getAnoFundacao());
            Console.WriteLine("Média Enem: " + e1.getMediaEnem() + "\n");

            Console.WriteLine("Endereço da Escola:");
            Console.WriteLine("Rua: " + e1.getEndereco().getRua());
            Console.WriteLine("Bairro: " + e1.getEndereco().getBairro());
            Console.WriteLine("Cidade: " + e1.getEndereco().getCidade());
            Console.WriteLine("Número: " + e1.getEndereco().getNumero());
            Console.WriteLine("CEP: " + e1.getEndereco().getCep());

        }
    }
}

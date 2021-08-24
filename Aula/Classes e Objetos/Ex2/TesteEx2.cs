using System;

namespace Ex2
{
    class TesteEx2
    {
        static void Main(string[] args)
        {
            //Cliente 1
            Cliente cl1 = new Cliente();
            Conta c1 = new Conta();

            c1.setAgencia("Caixa");
            c1.setNumero(015);
            c1.setSaldo(1250.00f);

            cl1.setNome("Geovanna");
            cl1.setSobrenome("Lima");
            cl1.setCpf("000.000.000-00");
            cl1.setConta(c1);

            Console.WriteLine("Informações do cliente 1:");
            Console.WriteLine("Nome:" + cl1.getnome());
            Console.WriteLine("Sobrenome:" + cl1.getSobrenome());
            Console.WriteLine("CPF:" + cl1.getCpf() + "\n");

            Console.WriteLine("Informações da Conta 1:");
            Console.WriteLine("Agência:" + cl1.getConta().getAgencia());
            Console.WriteLine("Número:" + cl1.getConta().getNumero());
            Console.WriteLine("Saldo:" + cl1.getConta().getSaldo() + "\n");

            //Cliente 2
            Cliente cl2 = new Cliente();
            Conta c2 = new Conta();

            c2.setAgencia("Itaú");
            c2.setNumero(014);
            c2.setSaldo(2150.00f);

            cl2.setNome("Flávia");
            cl2.setSobrenome("Lima");
            cl2.setCpf("111.111.111-11");
            cl2.setConta(c2);

            Console.WriteLine("Informações do cliente 2:");
            Console.WriteLine("Nome:" + cl2.getnome());
            Console.WriteLine("Sobrenome:" + cl2.getSobrenome());
            Console.WriteLine("CPF:" + cl2.getCpf() + "\n");

            Console.WriteLine("Informações da Conta 2:");
            Console.WriteLine("Agência:" + cl2.getConta().getAgencia());
            Console.WriteLine("Número:" + cl2.getConta().getNumero());
            Console.WriteLine("Saldo:" + cl2.getConta().getSaldo() + "\n");

            //Cliente 3
            Cliente cl3 = new Cliente();
            Conta c3 = new Conta();

            c3.setAgencia("Bradesco");
            c3.setNumero(013);
            c3.setSaldo(3050.00f);

            cl3.setNome("Fabiana");
            cl3.setSobrenome("Lima");
            cl3.setCpf("222.222.222-22");
            cl3.setConta(c3);

            Console.WriteLine("Informações do cliente 3:");
            Console.WriteLine("Nome:" + cl3.getnome());
            Console.WriteLine("Sobrenome:" + cl3.getSobrenome());
            Console.WriteLine("CPF:" + cl3.getCpf() + "\n");

            Console.WriteLine("Informações da Conta 3:");
            Console.WriteLine("Agência:" + cl3.getConta().getAgencia());
            Console.WriteLine("Número:" + cl3.getConta().getNumero());
            Console.WriteLine("Saldo:" + cl3.getConta().getSaldo() + "\n");
        }
    }
}

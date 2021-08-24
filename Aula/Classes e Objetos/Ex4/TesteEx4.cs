using System;

namespace Ex4
{
    class TesteEx4
    {
        static void Main(string[] args)
        {
           
            //Postagem 1
            Postagem p1 = new Postagem();
            p1.setTitulo("Apresentação");
            p1.setData("22/08/2021");
            p1.setConteudo("Olá, eu sou a Geovanna!");
            p1.setVisitas(10);

            //Postagem 2
            Postagem p2 = new Postagem();
            p2.setTitulo("Conteúdo");
            p2.setData("23/08/2021");
            p2.setConteudo("Vamos ver C#!");
            p2.setVisitas(12);

            //Postagem 3
            Postagem p3 = new Postagem();
            p3.setTitulo("Exercício");
            p3.setData("24/08/2021");
            p3.setConteudo("Faça o exercício 1.");
            p3.setVisitas(11);


            //Percorrendo o Array
            Postagem[] pArray = new Postagem[3];
            pArray[0] = p1;
            pArray[1] = p2;
            pArray[2] = p3;

            //Usuário
            Usuario u1 = new Usuario();
            u1.setNome("Geovanna");
            u1.setSobrenome("Lima");
            u1.setSenha("G123@@");
            for (int i = 0; i < 3; i++)
            {
                u1.setPostagens(pArray);
            }

            //Exibição infos usuário
            Console.WriteLine("Informações do usuário:");
            Console.WriteLine("Nome:" + u1.getNome());
            Console.WriteLine("Sobrenome:" + u1.getSobrenome());
            Console.WriteLine("Senha:" + u1.getSenha() + "\n");

            //Exibição postagens
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Informações da Postagem " + (i + 1) +":");
                Console.WriteLine("Título:" + u1.getPostagens()[i].getTitulo());
                Console.WriteLine("Data:" + u1.getPostagens()[i].getData());
                Console.WriteLine("Conteúdo:" + u1.getPostagens()[i].getConteudo() + "\n");
            }
        }
    }
}

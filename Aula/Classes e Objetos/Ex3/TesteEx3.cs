using System;

namespace Ex3
{
    class TesteEx3
    {
        static void Main(string[] args)
        {
            //Aluno 1
            Aluno a1 = new Aluno();
            a1.setNome("Isabela");
            a1.setEmail("isabela@email.com");
            a1.setRegistroAluno("111111" +"\n");

            //Aluno 2
            Aluno a2 = new Aluno();
            a2.setNome("João");
            a2.setEmail("joao@email.com");
            a2.setRegistroAluno("222222" + "\n");

            //Aluno 3
            Aluno a3 = new Aluno();
            a3.setNome("Maria");
            a3.setEmail("maria@email.com");
            a3.setRegistroAluno("333333" + "\n");

            //Aluno 4
            Aluno a4 = new Aluno();
            a4.setNome("Alice");
            a4.setEmail("alice@email.com");
            a4.setRegistroAluno("444444" + "\n");

            //Disciplina
            Disciplina d = new Disciplina();
            d.setNome("Linguagem de Programação III");
            d.setDescricao("Desenvolvimento web com .NET");
            d.setTurma("313");

            //Percorrendo o Array
            Aluno[] aArray = new Aluno[4];
            aArray[0] = a1;
            aArray[1] = a2;
            aArray[2] = a3;
            aArray[3] = a4;
            for (int i = 0; i < 4; i++)
            {
                d.setAlunos(aArray);
            }

            //Exibição infos disciplina
            Console.WriteLine("Informações da Disciplina:");
            Console.WriteLine("Nome: " + d.getNome());
            Console.WriteLine("Descrição: " + d.getDescricao());
            Console.WriteLine("Turma: " + d.getTurma() + "\n");

            //Exibição infos aluno
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Informações do Aluno " + (i + 1) + ":");
                Console.WriteLine("Nome:" + d.getAlunos()[i].getNome());
                Console.WriteLine("Email:" + d.getAlunos()[i].getEmail());
                Console.WriteLine("Registro:" + d.getAlunos()[i].getRegistroAluno());
            }
        }
    }
}

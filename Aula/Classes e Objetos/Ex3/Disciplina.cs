using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Disciplina
    {
        private string nome;
        private string descricao;
        private string turma;
        private Aluno[] alunos = new Aluno[4];

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getDescricao()
        {
            return this.descricao;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getTurma()
        {
            return this.turma;
        }
        public void setTurma(string turma)
        {
            this.turma = turma;
        }

        public Aluno[] getAlunos()
        {
            return this.alunos;
        }
        public void setAlunos(Aluno[] alunos)
        {
            this.alunos = alunos;
        }
    }
}

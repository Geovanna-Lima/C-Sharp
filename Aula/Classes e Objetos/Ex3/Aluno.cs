using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Aluno
    {
        private string nome;
        private string registroAluno;
        private string email;

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getRegistroAluno()
        {
            return this.registroAluno;
        }
        public void setRegistroAluno(string registroAluno)
        {
            this.registroAluno = registroAluno;
        }

        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
    }
}

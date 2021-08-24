using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Endereco
    {
        private string rua;
        private string bairro;
        private string cidade;
        private int numero;
        private string cep;

        public string getRua()
        {
            return this.rua;
        }
        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public string getBairro()
        {
            return this.bairro;
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string getCidade()
        {
            return this.cidade;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public int getNumero()
        {
            return this.numero;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public string getCep()
        {
            return this.cep;
        }
        public void setCep(string cep)
        {
            this.cep = cep;
        }

    }
}

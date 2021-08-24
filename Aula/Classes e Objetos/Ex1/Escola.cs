using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Escola
    {
        private string nome;
        private int anoFundacao;
        private Endereco endereco;
        private float mediaEnem;

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getAnoFundacao()
        {
            return this.anoFundacao;
        }
        public void setAnoFundacao(int ano)
        {
            this.anoFundacao = ano;
        }

        public Endereco getEndereco()
        {
            return this.endereco;
        }
        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public float getMediaEnem()
        {
            return this.mediaEnem;
        }
        public void setMediaEnem(float media)
        {
            this.mediaEnem = media;
        }
    }
}

using System;

namespace Ex1
{
    class Pessoa
    {
        private string nome = "Geovanna";
        private string sobrenome = "Lima";
        private byte idade = 18;
        private float altura = 1.63F;
        private float peso = 60.0F;

        public string getNome()
        {
            return this.nome;
        }
    }
}


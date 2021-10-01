using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    abstract class Forma
    {
        private string cor;

        protected void setCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine("Sua Cor é: " + cor);
        }

        public abstract double calcularArea();
    }
}

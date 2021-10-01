using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Retangulo : Forma
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            base.setCor("Vermelho");
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Área do retângulo: " + this.calcularArea() + "\n");
        }

        public Retangulo(double altura, double largura, string cor)
        {
            base.setCor(cor);
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Área do retângulo: " + this.calcularArea() + "\n");
        }

        public override double calcularArea()
        {
            return altura * largura;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            base.setCor("Amarelo");
            this.raio = raio;
            Console.WriteLine("Área do circulo: " + this.calcularArea() + "\n");
        }

        public Circulo(double raio, string cor)
        {
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("Área do circulo: " + this.calcularArea() + "\n");
        }

        public override double calcularArea()
        {
            return 3.14 * (Math.Pow(raio,2));
        }
    }
}


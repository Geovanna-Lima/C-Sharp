using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            base.setCor("Azul");
            this.lado = lado;
            Console.WriteLine("Área do quadrado: " + this.calcularArea() + "\n");
        }

        public Quadrado(double lado, string cor)
        {
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("Área do quadrado: " + this.calcularArea() + "\n");
        }

        public override double calcularArea()
        {
            return Math.Pow(lado,2);
        }

    }
}

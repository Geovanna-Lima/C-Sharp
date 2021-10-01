using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Triangulo : Forma
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            base.setCor("Branco");
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            Console.WriteLine("Área do triângulo: " + this.calcularArea() + "\n");
        }

        public Triangulo(double altura, double baseTriangulo, string cor)
        {
            base.setCor(cor);
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            Console.WriteLine("Área do triângulo: " + this.calcularArea() +"\n");
        }

        public override double calcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Triangulo : IForma
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public double calcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }
    }
}

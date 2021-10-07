using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Quadrado : IForma
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public double calcularArea()
        {
            return Math.Pow(lado, 2);
        }
    }
}

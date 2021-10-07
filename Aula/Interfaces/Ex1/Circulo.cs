using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Circulo : IForma
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double calcularArea()
        {
            return 3.14 * (Math.Pow(raio, 2));
        }
    }
}

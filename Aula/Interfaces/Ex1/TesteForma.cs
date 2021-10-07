using System;

namespace Ex1
{
    class TesteForma
    {
        static void mostrarArea(IForma forma)
        {
            Console.WriteLine("Área do "  + forma  + ": " + forma.calcularArea() + "\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Retângulo");
            IForma forma = new Retangulo(5.0, 7.5);
            mostrarArea(forma);

            Console.WriteLine("Círculo");
            forma = new Circulo(3.5);
            mostrarArea(forma);

            Console.WriteLine("Quadrado");
            forma = new Quadrado(10.0);
            mostrarArea(forma);

            Console.WriteLine("Triângulo");
            forma = new Triangulo(2.0, 5.5);
            mostrarArea(forma);
        }
    }
}

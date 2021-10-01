using System;

namespace Ex1
{ 
    class TesteForma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Quadrados =====");
            Quadrado quad1 = new Quadrado(15.0);
            Quadrado quad2 = new Quadrado(10.0, "Verde");

            Console.WriteLine("===== Retângulos =====");
            Retangulo rtn1 = new Retangulo(6.0, 9.5);
            Retangulo rtn2 = new Retangulo(11.0, 7.0, "Laranja");

            Console.WriteLine("===== Circulos =====");
            Circulo crc1 = new Circulo(3.0);
            Circulo crcc2 = new Circulo(5.5, "Roxo");

            Console.WriteLine("===== Triângulos =====");
            Triangulo trl1 = new Triangulo(20.5, 15.0);
            Triangulo trl2 = new Triangulo(3.0, 6.0, "Turquesa");
        }
    }
}

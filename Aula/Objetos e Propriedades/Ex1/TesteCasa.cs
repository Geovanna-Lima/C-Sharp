using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class TesteCasa
    {
        static void Main(string[] args)
        {
            Casa c1 = new Casa();
            c1.Area = 200.5F;
            c1.Altura = 10.0F;
            c1.Preco = 510000;

            Console.WriteLine("A área da casa é: " + c1.Area + "m");
            Console.WriteLine("A altura da casa é: " + c1.Altura + "m");
            Console.WriteLine("O preço da casa é: R$ " + c1.Preco);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class TestePessoa
    {
        static void Main(string[] args )
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine("O valor dentro do atributo nome é: " + p1.getNome());
        }
    }
}

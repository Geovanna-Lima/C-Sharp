using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Mamifero : Animal
    {
        public Mamifero()
        {
            this.Acao();
        }

        protected override void Acao()
        {
            base.Acao();
            Console.WriteLine("Mamíferos:\n");
        }
    }
}
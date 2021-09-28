using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Gato : Mamifero
    {
        public Gato()
        {
            //this.Acao();
        }

        protected override void Acao()
        {
            base.Acao();
            Console.WriteLine("O som do Gato é o: Miado (miau miau)");
            Console.WriteLine("----------------");
        }
    }
}
    

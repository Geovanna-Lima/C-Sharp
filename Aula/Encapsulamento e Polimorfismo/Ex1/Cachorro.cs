using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
            //this.Acao();
        }

        protected override void Acao()
        {
            base.Acao();
            Console.WriteLine("O som do Cachorro é o: Latido (au au)");
            Console.WriteLine("----------------");
        }
    }
}

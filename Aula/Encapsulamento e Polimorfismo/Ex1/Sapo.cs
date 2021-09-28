using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Sapo : Anfibio
    {
        public Sapo()
        {
            //this.Acao();
        }

        protected override void Acao()
        {
            base.Acao();
            Console.WriteLine("O som do Sapo é o: Coaxo (croac croac)");
            Console.WriteLine("----------------");
        }
    }
}

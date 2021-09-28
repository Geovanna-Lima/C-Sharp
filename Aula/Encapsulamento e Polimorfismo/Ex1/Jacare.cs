using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            //this.Acao();
        }

        protected override void Acao()
        {
            base.Acao();
            Console.WriteLine("O som do Jacaré é o: Rugido (roar roooor)");
            Console.WriteLine("----------------");
        }
    }
}


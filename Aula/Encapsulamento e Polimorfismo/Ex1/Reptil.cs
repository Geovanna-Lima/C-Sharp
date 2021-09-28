using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Reptil : Animal
    {
        public Reptil()
        {
            this.Acao();
        }

        protected override void Acao()
        {
            base.Acao();
            Console.WriteLine("Répteis:\n");
        }
    }
}

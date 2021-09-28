using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Anfibio : Animal
    {
        public Anfibio()
        {
            this.Acao();
        }

        protected override void Acao()
        {
            base.Acao();
            Console.WriteLine("Anfíbios:\n");
        }
    }
}

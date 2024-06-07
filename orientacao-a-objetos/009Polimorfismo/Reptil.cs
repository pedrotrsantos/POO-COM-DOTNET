using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal abstract class Reptil : Animal
    {
        protected string CorEscama { get; set; }

        public override void Locomover()
        {
            Console.WriteLine("Rastejando");
        }
        public override void Alimentar()
        {
            Console.WriteLine("Comendo insetos");
        }
        public override void EmitirSom()
        {
           Console.WriteLine("Som de reptil");
        }

    }
}

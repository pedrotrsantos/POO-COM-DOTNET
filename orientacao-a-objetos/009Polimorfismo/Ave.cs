using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal abstract class Ave : Animal
    {
        protected string CorPena { get; set; }

        public void SetCorPena(string corPena)
        {
            CorPena = corPena;
        }

        public override void Locomover()
        {
            Console.WriteLine("Voando");
        }
        public override void Alimentar()
        {
            Console.WriteLine("Comendo frutas");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Som de passaro");
        }
    }
}

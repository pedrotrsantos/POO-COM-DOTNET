using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal abstract class Mamifero : Animal
    {
        protected string CorPelo { get; set; }

        public void SetCorPelo(string corPelo)
        {
            CorPelo = corPelo;
        }
        public override void Locomover()
        {
            Console.WriteLine("Correndo");
        }
        
        public override void Alimentar()
        {
            Console.WriteLine("Mamando");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo som");
        }

    }
}

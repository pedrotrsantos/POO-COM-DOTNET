using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal abstract class Peixe : Animal
    {
        protected string CorEscama {get; set;}

        public void SetCorEscama(string corEscama)
        {
            CorEscama = corEscama;
        }

        public override void Locomover()
        {
            Console.WriteLine("Nadando");
        }
        public override void Alimentar()
        {
            Console.WriteLine("Comendo algas");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Peixe nao faz som!");
        }
    }
}

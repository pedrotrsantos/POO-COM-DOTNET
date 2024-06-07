using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal class Canguru : Mamifero
    {
        public void UsarBolsa()
        {
            Console.WriteLine("Usando bolsa");
        }
        public override void Locomover()
        {
            Console.WriteLine("Pulando");
        }
    }
}

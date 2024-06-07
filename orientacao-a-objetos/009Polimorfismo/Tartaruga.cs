using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal class Tartaruga : Reptil
    {
        public override void Locomover()
        {
            Console.WriteLine("Andando beeeeemmm devagar");
        }
    }
}

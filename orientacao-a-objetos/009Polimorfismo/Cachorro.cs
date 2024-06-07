using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal class Cachorro : Mamifero
    {
        public void EnterrarOsso()
        {
            Console.WriteLine("Enterrando osso!");
        }
        public void AbanarRabo()
        {
            Console.WriteLine("Abanando o Rabo");
        }
    }
}

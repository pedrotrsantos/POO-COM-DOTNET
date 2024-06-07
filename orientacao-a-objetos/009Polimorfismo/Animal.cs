using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal abstract class Animal
    {
        protected double Peso {  get; set; }
        protected int Idade { get; set; }
        protected int Membros { get; set; }
        public virtual void Locomover() { }
        public virtual void Alimentar() { }
        public virtual void EmitirSom() { }

        public void SetPeso(double peso)
        {
            Peso = peso;
        }
        public void SetIdade(int idade)
        {
            Idade = idade;
        }
        public void SetMembros(int membros)
        {
            Membros = membros;
        }

        public void Status()
        {
            Console.WriteLine($"-------- Animal---------\n");
            Console.WriteLine($"Peso {Peso}\n");
            Console.WriteLine($"Idade {Idade}\n");
            Console.WriteLine($"Membros {Membros}\n");
        }

    }
}

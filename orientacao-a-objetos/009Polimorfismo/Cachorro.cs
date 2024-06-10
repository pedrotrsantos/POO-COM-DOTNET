using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009Polimorfismo
{
    internal class Cachorro : Mamifero
    {
        public void Reagir(string frase)
        {
            if (frase == "tchitiu")
            {
                AbanarRabo();
                Latir();
            }
            else
            {
                Rosnar();
            }
        }

        public void Reagir(int hora, int min)
        {
            if (hora > 5 & hora < 12)
            {
                AbanarRabo();
            }
            else if (hora >= 12 & hora < 18)
            {
                AbanarRabo();
                Latir();
            }
            else 
            { 
                Ignorar();
            }
        }

        public void Reagir(bool dono)
        {
            if (dono)
            {
                AbanarRabo();
            }
            else
            {
                Rosnar();
                Latir();
            }
        }
        
        public void Reagir(int idade, double peso)
        {
            if (idade < 3 & peso < 5.00)
            {
                AbanarRabo();
            }else if(idade < 3 & peso > 5.00)
            {
                Latir();
            }else if(idade > 3 & peso < 5.00)
            {
                Rosnar();
            }
            else
            { 
                Ignorar();
            }
        }
        private void Rosnar()
        {
            Console.WriteLine("Rosnando!");
        }
        private void Latir()
        {
            Console.WriteLine("AU! AU! AU!");
        }
        private void Ignorar()
        {
            Console.WriteLine("...");
        }

        private void AbanarRabo()
        {
            Console.WriteLine("Abanando o Rabo");
        }
    }
}

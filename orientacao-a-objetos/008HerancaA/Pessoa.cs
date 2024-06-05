using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008HerancaA
{
    public abstract class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Sexo { get; private set; }

        public virtual void Status()
        {
            Console.WriteLine($"Nome: {Nome}\n" +
                $"Idade: {Idade} anos\n" +
                $"Sexo: {Sexo}\n");
        }

        public void Config()
        {

            Console.WriteLine("Digite o seu nome: ");
            Nome = Console.ReadLine();

            int idade;
            bool entradaValida;

            do
            {
                Console.WriteLine("Quantos anos você tem? ");

                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out idade))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite somente números.");
                    entradaValida = false;
                }
                else if (idade <= 0)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número maior que 0.");
                    entradaValida = false;
                }
                else
                {
                    entradaValida = true;
                }
            }
            while (!entradaValida);
            Idade = idade;

            Console.WriteLine("Digite o seu sexo:");
            Sexo = Console.ReadLine();
            Console.WriteLine("\n");
        }
      
        public void FazerAniversario()
        {
            Idade++;
            Console.WriteLine("Feliz aniversário!\n");
        }
    }
}

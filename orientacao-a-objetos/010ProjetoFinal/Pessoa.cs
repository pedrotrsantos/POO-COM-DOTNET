using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010ProjetoFinal
{
    internal abstract class Pessoa
    {
        protected string Nome {get; set; }
        protected int Idade { get; set; }
        protected string Sexo { get; set; }
        protected int Experiencia { get; set; }

        public Pessoa(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Experiencia = 0;
           
        }

        public void CriarPessoa()
        {
            Console.WriteLine("Digite o nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            Idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu sexo:");
            Sexo = Console.ReadLine();
        }
        public void Status()
        {
            Console.WriteLine($"Nome: {Nome}\n" +
                $"Idade: {Idade}\n" +
                $"Sexo: {Sexo}\n" +
                $"Experiência: {Experiencia}");
        }

        public void GanharXp()
        {
            Experiencia++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010ProjetoFinal
{
    internal class Gafanhoto : Pessoa
    {
        private string Login { get; set; }
        private int TotalAssistido { get; set; }

        public Gafanhoto(string nome, int idade, string sexo, string login) : base(nome, idade, sexo)
        {
          Login = login;
          TotalAssistido = 0; 
        }
        public void ViuMaisUm()
        {
            TotalAssistido++;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                     $"Idade: {Idade}\n" +
                     $"Sexo: {Sexo}\n" +
                     $"Experiência: {Experiencia}\n" +
                     $"Login: {Login}\n" +
                     $"Total assistido: {TotalAssistido}\n";
        }
    }
}

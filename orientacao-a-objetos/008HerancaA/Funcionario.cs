using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _008HerancaA
{
    internal class Funcionario : Pessoa
    {
        string Setor { get; set; }
        bool Trabalhando { get; set; }

        string[] Setores = new string[4] { "Secretaria", "Biblioteca", "Cantina", "Supervisao" };

        public Funcionario() {
            Trabalhando = true;
        }

        private void GerarSetor()
        {
            Random rnd = new Random();
            int r = rnd.Next(Setores.Length);
            Setor = Setores[r];
        }

        public void MudarTrabalho()
        {
            Trabalhando = !Trabalhando;

            if (Trabalhando == true)
            {
                Console.WriteLine("Começou a trabalhar\n");
            }
            else
            {
                Console.WriteLine("Parou de trabalhar\n");
            }
        }
        private void StatusTrabalho()
        {
            if (Trabalhando == true)
            {
                Console.WriteLine("Está trabalhando\n");
            }
            else
            {
                Console.WriteLine("Não está trabalhando\n");
            }
        }

        public void GerarFuncinario()
        {
            Config();
            GerarSetor();
        }
        public override void Status()
        {
            Console.WriteLine($"O Funcionario: {Nome}\n" +  $"Setor: {Setor}");
            StatusTrabalho();
            Console.WriteLine("\n");
        }
    }
}

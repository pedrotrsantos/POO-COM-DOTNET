using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008HerancaA
{
    internal class Professor : Pessoa
    {
        string Nivel { get; set; }
        double Salario { get; set; }

        string[] Niveis = new string[3] { "Bacharel", "Doutorado", "Mestrado"};

        private void GerarNivel()
        {
            Random rnd = new Random();
            int r = rnd.Next(Niveis.Length);
            Nivel = Niveis[r];
        }

        private void GerarSalario()
        {
            Random rnd = new Random();
            Salario = rnd.Next(1400, 2000);
        }

        public void ReceberAumento(double aumento)
        {    
            Salario += aumento;
            Console.WriteLine($"Recebeu um aumento de {aumento} reais \n"); 
            StatusProfessor();
        }

        public void GerarProfessor()
        {
            Config();
            GerarNivel();
            GerarSalario();
        }

        public void StatusProfessor()
        {
           
            Console.WriteLine($"O professor: {Nome}\n" +
                $"de {Idade} anos\n" +
                $"Sexo: {Sexo}\n" +
                $"Nivel: {Nivel}\n" +
                $"Salário: {Salario}\n");
        }
    }
}

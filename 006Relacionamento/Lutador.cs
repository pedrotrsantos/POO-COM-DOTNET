using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Relacionamento
{
    public class Lutador
    {
        public string Nome { get; set; }
        private string Nacionalidade { get; set; }
        private int Idade { get; set; }
        private double Altura { get; set; }
        private double Peso { get; set; }
        public string Categoria { get; set; }
        private int Vitorias { get; set; }
        private int Derrotas { get; set; }
        private int Empates { get; set; }

        public Lutador(string nome, string nacionalidade, int idade, double altura, double peso, int vitorias, int derrotas, int empates)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            Idade = idade;
            Altura = altura;
            Peso = peso;
            Vitorias = vitorias;
            Derrotas = derrotas;
            Empates = empates;
            Categoria = DefinirCategoria();
        }

        public string DefinirCategoria()
        {
            if (Peso < 52.2)
            {
                return Categoria = "Inválido";
            }
            else if (Peso <= 70.3)
            {
                return Categoria = "Leve";
            }
            else if (Peso <= 83.9)
            {
                return Categoria = "Médio";
            }
            else if (Peso <= 120.2)
            {
                return Categoria = "Pesado";
            }
            else {
                return Categoria = "Inválida";
            }
        }
        public void Apresentar() {
            Console.WriteLine("----- APRESENTAÇÃO ----- ");
            Console.WriteLine($"Lutador : {Nome}");
            Console.WriteLine($"Origem: {Nacionalidade}");
            Console.WriteLine($"Com {Idade} anos");
            Console.WriteLine($"Altura {Altura}m e pesando {Peso} Kg");
            Console.WriteLine($"Ganhou: {Vitorias}");
            Console.WriteLine($"Perdeu: {Derrotas}");
            Console.WriteLine($"Empatou: {Empates}  \n");
        }
        public void Status()
        {
            Console.WriteLine("----- STATUS -----");
               Console.WriteLine($"É um peso {Categoria}");
            Console.WriteLine($"Com {Vitorias} vitórias, {Derrotas} derrotas e {Empates} empates  \n ");
        }
        public void GanharLuta()
        {
            Vitorias += 1;
        }

        public void PerderLuta()
        {
            Derrotas += 1;
        }
        public void EmpatarLuta()
        {
            Empates += 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007ExerciciosPoo
{
     class Pessoa
    {
        private string Nome;
        private int Idade;
        private string Sexo;

        public Pessoa(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        public string GetNome()
        {
            return Nome;
        }
     
        public int GetIdade()
        {
            return Idade;
        }
        public string GetSexo(){
            return Sexo;
        }

        public void fazerAniver() {
            Idade++;
        }

    }
}

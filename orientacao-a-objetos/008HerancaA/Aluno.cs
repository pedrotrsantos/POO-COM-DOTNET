using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008HerancaA
{
    internal class Aluno : Pessoa
    {
        int Matricula { get; set; }
        string Curso { get; set; }

        string[] Cursos = new string[5] { "ADS", "Direito", "Adminstracao", "Fisica", "Medicina" };

        public void EscolherCurso()
        {
            Console.WriteLine("Escolha seu curso entre os disponiveis:");
            foreach (string c in Cursos)
            {
                Console.WriteLine(c);
            }

            string nomeCurso;
            bool respostaValida = false;

            do  
            {
              
                Console.WriteLine("Qual você quer cursar?");
                var resposta = Console.ReadLine();

                Console.WriteLine("\n");

                if (string.IsNullOrWhiteSpace(resposta))
                {
                    Console.WriteLine("Voce nao digitou nada, por favor escolha um curso");
                }
                else
                {
                    foreach(string cursoValidoDoArray in Cursos)
                    {
                        if (string.Equals(resposta, cursoValidoDoArray, StringComparison.OrdinalIgnoreCase))
                        {
                            nomeCurso = cursoValidoDoArray;
                            respostaValida = true;
                            Curso = nomeCurso;
                            break;    
                        }
                    }

                    if (!respostaValida)
                    {
                        Console.WriteLine("Curso náo encontrado, por favor digite um curso válido");
                    }
                }
            } 
            while (!respostaValida);

        }
        private void GerarCurso()
        {
            Random rnd = new Random();
            int r = rnd.Next(Cursos.Length);
            Curso = Cursos[r];
           
        }
        private void GerarMatricula()
        {
            Random rdn = new Random();
            Matricula = rdn.Next(999,9999);
          
        }
        public void CancelarMatricula() {
            Console.WriteLine($"Sua matricula {Matricula} foi cancelada");
        }

        public void GerarAluno()
        {
            Config();
            GerarMatricula();
            // GerarCurso();
            EscolherCurso();
        }
        
        public override void Status()
        {
            Console.WriteLine($"O aluno: {Nome}\n" +
                $"de {Idade} anos\n" +
                $"Sexo: {Sexo}\n" +
                $"Curso: {Curso}\n" +
                $"Matrícula: {Matricula}");
        }
    }
}

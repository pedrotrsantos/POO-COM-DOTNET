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
        protected int Matricula { get; set; }
        public string Curso { get; set; }
        protected bool MensalidadePaga { get;  set; }
        public double ValorMensalidade { get; set; }
        protected string StatusMensalidade { get; set; }

        protected  string Tipo { get; set; }
        string[] Cursos = new string[5] { "ADS", "Direito", "Adminstracao", "Fisica", "Medicina" };

        string[] Tipos = new string[3] {"Comum", "Bolsista", "Técnico" };

        public Aluno()
        {
            ValorMensalidade = 1000.00;
            MensalidadePaga = false;
            Tipo = "Comum";
        }

        protected void EscolherCurso()
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
        private void GerarTipo()
        {
            Random rnd = new Random();
            int r = rnd.Next(Tipos.Length);
            Tipo = Tipos[r];
        }
        protected void GerarMatricula()
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
           // GerarTipo();

        }

        public virtual void PagarMensalidade(double valorPago)
        {
            if (valorPago < ValorMensalidade)
            {
                Console.WriteLine("Sua não foi paga! Valor insuficiente\n");
            }else if( valorPago > ValorMensalidade)
            {
                double troco = valorPago - ValorMensalidade; 
                Console.WriteLine($"Sua mensalidade foi paga!Você tem R${troco} de troco\n");
                MensalidadePaga = true;
            }
            else
            {
                MensalidadePaga = true;
                Console.WriteLine("Sua mensalidade foi paga!\n");
            }
        }

        protected void AlterarStatusMensalidade()
        {
            if (MensalidadePaga == true)
            {
                StatusMensalidade = "Quitada";
            }
            else
            {
                StatusMensalidade = "Em débito";
            }
        }
        
        public override void Status()
        {
            AlterarStatusMensalidade();
            Console.WriteLine($"Aluno: {Nome}\n" +
                $"Idade {Idade} anos\n" +
                $"Sexo: {Sexo}\n" +
                $"Curso: {Curso}\n" +
                $"Matrícula: {Matricula}\n" +
                $"Tipo: {Tipo}\n" +
                $"Mensalidade: {ValorMensalidade}\n" +
                $"Estado: {StatusMensalidade} \n");
        }
    }
}

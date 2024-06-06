using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008HerancaA
{
    internal class Bolsista : Aluno
    {
        private double Bolsa { get; set; }
        
        public Bolsista() 
        {
            Bolsa = ValorMensalidade;
            Tipo = "Bolsista";
            MensalidadePaga = true;
        }

        public void RenovarBolsa()
        {
            Bolsa += ValorMensalidade;

        }
    
        public override void PagarMensalidade(double valorPago)
        {
            if(Tipo == "Bolsista")
            {
                Console.WriteLine("Você possui bolsa!\n");
              
            }
        }



        public override void Status()
        {
            AlterarStatusMensalidade();
            Console.WriteLine($"Aluno: {Nome}\n" +
                $"Idade: {Idade} anos\n" +
                $"Sexo: {Sexo}\n" +
                $"Curso: {Curso}\n" +
                $"Matrícula: {Matricula}\n" +
                $"Tipo: {Tipo}\n" +
                $"Bolsa: R${Bolsa}\n" +
                $"Mensalidade: {ValorMensalidade}\n" +
                $"Estado: {StatusMensalidade} \n");
        }
    }
}

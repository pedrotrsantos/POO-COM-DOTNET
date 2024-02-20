using System;


namespace _03ExercicioEscolar
{
    internal class Aluno
    {
        //Atributos
        public string nome;
        public double nota1, nota2;

        //Media
        public double media()
        {
            return (nota1 + nota2) / 2;
        }

        //Situação

        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }

        //Mensagem

        public void mensagem() {

            //obter média
            double obterMedia = media();

            //obter situaação
            string obterSituação = situacao(obterMedia);

            //mensagem
            Console.WriteLine(nome + " está " + obterSituação + " com média " + obterMedia);
           
        }
    }
} 

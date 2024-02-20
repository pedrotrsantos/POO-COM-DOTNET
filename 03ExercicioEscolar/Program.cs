using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar objeto

            Aluno a  = new Aluno();
            a.nome = "Pedro";
            a.nota1 = 8;
            a.nota2 = 9;
            a.mensagem();
        }
    }
}
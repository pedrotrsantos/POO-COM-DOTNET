using System;

namespace _04ExercicioIMC
{
    class Program
    {

        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("CALCULADOR DE IMC \n \n");

            Console.WriteLine("Digite o seu peso: ");

            pessoa.peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sua altura em metros:  ");
            var altura = Console.ReadLine().Replace(".", ",");
            pessoa.altura = double.Parse(altura);

            pessoa.mensagem();
        }
    }

}


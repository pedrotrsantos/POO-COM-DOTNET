using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Encapsulamento
{
    class Aluno
    {
        private double nota1, nota2;

        private double media()
        {
            return (nota1 + nota2)/2;
        }

        public void mensagem()
        {
            Console.WriteLine("Escreva a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média é:  " + media());
        }

    }
}

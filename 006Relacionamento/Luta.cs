using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Relacionamento
{
     public class Luta
    {
        private Lutador Desafiado { get; set; }
        private Lutador Desafiante { get; set; }
        private int Rounds;
        private bool Aprovada;

        public void MarcarLuta( Lutador lutador1,  Lutador lutador2)
        {
            if (lutador1.Categoria == lutador2.Categoria & (lutador1 != lutador2))
            {
                Aprovada = true;
                Desafiado = lutador1;
                Desafiante = lutador2;
                Console.WriteLine("A luta  foi marcada");
            }
            else if (lutador1.Categoria != lutador2.Categoria)
            {
                Aprovada = false;
                Console.WriteLine("A luta não foi marcada, categorias diferentes");
            }

            else if (lutador1 == lutador2)
            {
                Aprovada = false;
                Console.WriteLine("A luta não foi marcada, o lutador nao pode lutar contra ele mesmo");
            }

            else
            {
                Aprovada = false;
                Console.WriteLine("A luta não foi marcada \n");
            }
        }

        public void Lutar()
        {
            if (Aprovada)
            {
                Console.WriteLine("### IIIIITTT'SSSS TIMEEEEEE! ###' \n ");
                Console.WriteLine("### DESAFIADO ###' \n ");
                Desafiado.Apresentar();
                Console.WriteLine("### DESAFIANTE ###' \n ");
                Desafiante.Apresentar();

                var GerarRandon = new Random();
                int  Vencedor = GerarRandon.Next(3);

                switch (Vencedor)
                {
                    case 0:
                        Console.WriteLine("EMPATOU  \n ");
                        Desafiado.EmpatarLuta();
                        Desafiante.EmpatarLuta();
                        break;

                    case 1:
                        Console.WriteLine($"Ganhou o desafiado: {Desafiado.Nome} \n ");
                        Desafiado.GanharLuta();
                        Desafiante.PerderLuta();
                        break;
                    case 2:
                        Console.WriteLine($"Ganhou o desafiante: {Desafiante.Nome}  \n ");
                        Desafiado.PerderLuta();
                        Desafiante.GanharLuta();                   
                        break;
                }
            }
            else
            {
                Console.WriteLine("Essa luta não foi aprovada");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007ExerciciosPoo
{
    internal class Livro : IPublicacao
    {
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private int TotPaginas { get; set; } 
        private int PagAtual { get; set; }
        private bool Aberto { get; set; }
        private Pessoa Leitor { get; set; }

        public Livro(string titulo, string autor, int totPaginas, Pessoa leitor)
        {
            Titulo = titulo;
            Autor = autor;
            TotPaginas = totPaginas;
            Leitor = leitor;
            Aberto = false;
            PagAtual = 0;
        }


        public void detalhes()
        {
            Console.WriteLine($" ---- Detalhes do livro ---- \n");
            Console.WriteLine($" O livro {Titulo}");
            Console.WriteLine($" de {Autor}");
            Console.WriteLine($" contém {TotPaginas} páginas");
            Console.WriteLine($" Está sendo lendo por {Leitor.GetNome()}, {Leitor.GetSexo()}, de {Leitor.GetIdade()} anos");
            Console.WriteLine($" Está na página {PagAtual}");
        }
        
        public void abrir()
        {
            if(Aberto == true)
            {
                Console.WriteLine("O LIVRO JÁ ESTÁ ABERTO, SEU MULA!");
            }else 
            {
                Aberto = true;
                Console.WriteLine("O LIVRO FOI ABERTO");
            }
        }
        public void fechar()
        {
            if( Aberto == false )
            {
                Console.WriteLine("O LIVRO JÁ ESTÁ FECHADO, SEU MULA!");
            }
            else
            {
                Aberto = false;
                Console.WriteLine("O LIVRO FOI FECHADO");
            }
        }
    
        public void avancarPag()
        {   
            if ( Aberto == false)
            {
                Console.WriteLine("O LIVRO J ESTÁ FECHADO, SEU MULA!");
            }
            else if ( PagAtual == TotPaginas)
            {
                Console.WriteLine("NÃO PODE AVANÇAR MAIS, VOCÊ ESTÁ NA ULTIMA PAGINA");
            }
            else
            {
                PagAtual++;
            }
         
        }
        public void voltarPag()
        {
            if (Aberto == false)
            {
                Console.WriteLine("O LIVRO J ESTÁ FECHADO, SEU MULA!");
            }
            else if (PagAtual == 0)
            {
                Console.WriteLine("NÃO PODE VOLTAR MAIS, VOCÊ ESTÁ NA PRIMEIRA PAGINA");
            }
            else {
                PagAtual--;
            }
           
        }
        public void folhear(int pagina)
        {
            if (Aberto == false)
            {
                Console.WriteLine("O LIVRO J ESTÁ FECHADO, SEU MULA!");
            }
            else if (pagina > TotPaginas)
            {
                Console.WriteLine("NAO PODE FOLHEAR MAIS QUE AS PAGINAS DO LIVRO, SEU MULA!");
            }
            else
            {
                PagAtual = pagina;
            }

        }
    }
}

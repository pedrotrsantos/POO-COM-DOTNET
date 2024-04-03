using _007ExerciciosPoo;
using System;

public class ProjetoLivro
{
    public static void Main(String[] args)
    {
        Pessoa[] p = new Pessoa[2];
        Livro[] l = new Livro[3];

        p[0] = new Pessoa("Lucas", 25, "Homem");
        p[1] = new Pessoa("Ana", 20, "Mulher");

        l[0] = new Livro("Harry Potter", "J. K. Rowling", 200, p[0]);
        l[1] = new Livro("Biblia Sagrada", "Deus", 500, p[1]);
        l[2] = new Livro("O vendedor de sonhos", "Augusto Cury", 100, p[1]);

        l[2].abrir();
        l[2].folhear(100);
        l[2].avancarPag();
        l[2].detalhes();
    }
}
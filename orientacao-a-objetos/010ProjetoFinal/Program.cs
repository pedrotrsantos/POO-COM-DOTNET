using _010ProjetoFinal;
using System;
using System.Runtime.Intrinsics;

class Program
{
    static void Main(string[] args)
    {
        Gafanhoto[] g = new Gafanhoto[1];
        g[0] = new Gafanhoto("Pedro", 22, "M", "PedJump");
        // g[1].CriarPessoa();
        g[0].GanharXp();
       

        Video[] v = new Video[3];
        v[0] = new Video("Aula 1");
        v[1] = new Video("Aula 2");
        v[2] = new Video("Aula 3");


        Visualizacao[] vs = new Visualizacao[3];
        vs[0] = new Visualizacao(g[0], v[0]);
        vs[1] = new Visualizacao(g[0], v[0]);
        vs[2] = new Visualizacao(g[0], v[0]);
        vs[0].Avaliar(100f);
        vs[0].Avaliar();
        vs[0].Avaliar(5);
        Console.WriteLine(vs[0].ToString());


    }
}
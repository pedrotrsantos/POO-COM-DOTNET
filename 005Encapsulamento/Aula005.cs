using _005Encapsulamento;
using System;

class Aula005 
{
    static void Main(string[] args)
    {
        ControleRemoto c1 = new ControleRemoto();
        c1.Ligar();
        c1.Pause();
        c1.MaisVolume();
        c1.AbrirMenu();
    }
}
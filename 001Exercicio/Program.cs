using _001Exercicio;
using System;

class Program
{
    public static void Main(string[] args) 
    {
        Mouse mouse1 = new Mouse();
        mouse1.modelo = "M3";
        mouse1.marca = "Darmoshark";
        mouse1.cor = "branco";
        mouse1.dpi = 21000;
        mouse1.peso = 88.0f;
        mouse1.status();

        Mouse mouse2 = new Mouse();
        mouse2.modelo = "Warrior";
        mouse2.marca = "Multilaser";
        mouse2.cor = "prata";
        mouse2.dpi = 2600;
        mouse2.peso = 150.0f;
        mouse2.status();
    }
}
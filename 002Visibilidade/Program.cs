using _002Visibilidade;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Caneta c1 = new Caneta();
        c1.modelo = "BIC CRISTAL";
        c1.cor = "rosa";
        c1.tampar();
        c1.rabiscar();
        c1.carga = 80;
        c1.status();
    }
} 
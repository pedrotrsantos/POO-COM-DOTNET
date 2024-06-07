using _009Polimorfismo;
using System;

class Program
{
    static void Main(string[] args)
    {

        Canguru canguru = new Canguru();
        Cachorro c1 = new Cachorro();
        c1.Locomover();
        c1.AbanarRabo();
        canguru.Locomover();
        canguru.SetCorPelo("pRETO");
        canguru.SetPeso(28.0);
        canguru.Status();

    }
}
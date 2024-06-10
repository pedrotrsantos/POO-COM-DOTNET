using _009Polimorfismo;
using System;

class Program
{
    static void Main(string[] args)
    {

        Canguru canguru = new Canguru();
        Cachorro c1 = new Cachorro();
        c1.Reagir("tchitiu");
        c1.Reagir(5,2);
        c1.Reagir(false);
        c1.Reagir(10, 2.0);
    }
}
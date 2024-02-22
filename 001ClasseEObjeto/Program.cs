
using System;

namespace _001ClasseEObjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Caneta c1 = new Caneta();
            c1.cor = "Azul";
            c1.ponta = 0.5f;
            c1.modelo = "bic";
            c1.tampar();
            c1.status();
            c1.rabiscar();

            Caneta c2 = new Caneta();
            c2.cor = "Preta";
            c2.modelo = "Vasco";
            c2.destampar();
            c2.status();
            c2.rabiscar();
        }
    } 
}

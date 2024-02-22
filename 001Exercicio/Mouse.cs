using System;


namespace _001Exercicio
{
    internal class Mouse
    {
        public string cor;
        public string marca;
        public string modelo;
        public int dpi;
        public float peso;

        public void status()
        {
            Console.WriteLine($"Mouse {marca} {modelo} {cor} com {peso}g e {dpi}dpi \n");
        }
    }
}

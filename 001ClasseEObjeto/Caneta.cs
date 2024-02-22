using System;


namespace _001ClasseEObjeto
{
    internal class Caneta
    {
       public string modelo;
       public string cor;
       public float ponta;
       public int carga;
       public bool tampada;

       public void status()
        {
            Console.WriteLine("Uma caneta " + cor);
            Console.WriteLine("está tampada? " + tampada);
        }

        public void rabiscar()
        {
            if (this.tampada == true)
            {
                Console.WriteLine("ERRO!, Não posso rabiscar");
            }
            else
            {
                Console.WriteLine("Estou rabiscando");
            }
        }
        public void tampar()
        {
            tampada = true;
        }
        public void destampar()
        {
            tampada = false;
        }
    } 
}

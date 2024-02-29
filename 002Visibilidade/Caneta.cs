using System;

namespace _002Visibilidade
{
         public class Caneta
        {
            public string modelo;
            public string cor;
            private float ponta;
            protected internal int carga;
            private bool tampada;

            public void status()
            {
                Console.WriteLine("Uma caneta " + cor);
                Console.WriteLine("está tampada? " + tampada);
                Console.WriteLine("Carga: " + carga);
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

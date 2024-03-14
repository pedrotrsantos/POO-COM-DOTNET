using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Encapsulamento
{
    class ControleRemoto : IControlador
    {
        private int Volume { get; set; }
        private bool Ligado { get; set; }
        private bool Tocando { get; set; }


        public ControleRemoto()
        { 
            Volume = 50;
            Ligado = true;
            Tocando = false;
        }
      

        public void Ligar()
        {
            Ligado = true;
        }

        public void Desligar()
        {
            Ligado = false;
        }

        public void AbrirMenu()
        {
            if (Ligado)
            {
                Console.WriteLine("---- MENU ----");
                Console.WriteLine($" Está ligado? {Ligado}");
                Console.WriteLine($" Está tocando? {Tocando}");
                Console.WriteLine($"Volume: {Volume}");

                for (int i = 0; i <= Volume; i += 10)
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                Console.WriteLine("Não foi possível abrir o menu");;
            }
        }

        public void FecharMenu()
        {
            Console.WriteLine( "Fechando menu...");
        }

        public void MaisVolume()
        {       
           if (Ligado == true)
            {
                Volume += 5;
            }else
            {
                Console.WriteLine( "Não foi possível aumentar o volume");
            }
        }

        public void MenosVolume()
        {
            if (Ligado == true)
            {
                Volume -= 5;
            }
            else
            {
                Console.WriteLine("Não foi possível diminuir o volume");
            }
        }

        public void LigarMudo()
        {
           if(Ligado == true && Volume > 0)
            {
                Volume = 0;
            }
            else
            {
                Console.WriteLine("Não foi possível deixar o mudo");
            }
        }

        public void DesligarMudo()
        {
            if (Ligado == true && Volume == 0)
            {
                Volume = 50;
            }
            else
            {
                Console.WriteLine("Não foi possível desligar o mudo");
            }
        }

        public void Play()
        {
          if (Ligado && Tocando == false)
            {
                Tocando = true;
            }
        }

        public void Pause()
        {
           if (Ligado && Tocando)
            {
                Tocando = false;
            }
        }
    }
}

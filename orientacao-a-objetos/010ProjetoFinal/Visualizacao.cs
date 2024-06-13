using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _010ProjetoFinal
{
    internal class Visualizacao
    {
        private Gafanhoto Espectador { get; set; }
        private Video Filme { get; set; }


        public Visualizacao(Gafanhoto Espectador, Video Filme) {
            this.Espectador = Espectador;
            this.Filme = Filme;
            this.Espectador.ViuMaisUm();
            this.Filme.AumentarView();
        }
        public void Avaliar()
        {
           Filme.SetAvaliacao(5);
        }
        public void Avaliar(int nota)
        {
            Filme.SetAvaliacao(nota);
        }
        public void Avaliar(float porcentagem)
        {
           
            if(porcentagem <= 0)
            {
                Filme.SetAvaliacao(0);
            }
            else if (porcentagem <= 20)
            {
                Filme.SetAvaliacao(1);
            }
            else if (porcentagem <= 40)
            {
                Filme.SetAvaliacao(2);
            }
            else if (porcentagem <= 60)
            {
                Filme.SetAvaliacao(3);
            }
            else if (porcentagem <= 80)
            {
                Filme.SetAvaliacao(4);
            }
            else
            {
                Filme.SetAvaliacao(5);
            } 
        }
        public override string ToString()
        {
            return $"Visualizacao \n"+
                $"Espectador:\n" +
                $"{Espectador}\n" +
                $"Filme:\n" +
                $"{Filme}";
        }

    }
}

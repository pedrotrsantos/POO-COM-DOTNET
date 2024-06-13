using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010ProjetoFinal
{
    internal class Video : IAcoesVideo
    {

        private string Titulo { get; set; }
        public double Avaliacoes { get; set; }
        private int Views { get; set; }
        private int Likes { get; set; }
        private bool Reproduzindo { get; set; }


        public Video(string titulo) { 
            Titulo = titulo;
            Avaliacoes = 0;
            Views = 0;
            Likes = 0;
            Reproduzindo = false;
        
        }
        public void Like()
        {
            Likes++;
        }

        public void Pause()
        {
            if (Reproduzindo)
            {
                Reproduzindo = false;
            }
            
        }

        public void Play()
        {
            if (!Reproduzindo)
            {
                Reproduzindo = true;
            }
        }
        public void AumentarView()
        {
            Views++;
        }

        public void SetAvaliacao(double avaliacao)
        {
            double media = (Avaliacoes + avaliacao) / Views;
            Avaliacoes = media;
            Avaliacoes = Math.Round(media, 2);
        }


        public override string ToString()
        {
           return $"Titulo: {Titulo}\n" +
                $"Avaliação: {Avaliacoes}\n" +
                $"Views: {Views}\n" +
                $"Curtidas: {Likes}\n" +
                $"Reproduzindo: {Reproduzindo}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Encapsulamento
{
    interface IControlador
    {
        public  void Ligar();
        public  void Desligar();
        public  void AbrirMenu();
        public  void FecharMenu();
        public void MaisVolume();
        public void MenosVolume();
        public void LigarMudo();
        public void DesligarMudo();
        public void Play();
        public void Pause();
    }
}

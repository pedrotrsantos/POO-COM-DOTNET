using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007ExerciciosPoo
{
    internal interface IPublicacao
    {
        public void abrir();
        public void fechar();
        public void folhear(int pagina);
        public void avancarPag();
        public void voltarPag();
    }
}

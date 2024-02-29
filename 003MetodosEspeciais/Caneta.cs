using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _003MetodosEspeciais
{
    public class Caneta
    {
        public string modelo;
        private bool tampada;
        private float ponta;
        public string getModelo()
        {
            return modelo;
        }
        public void setModelo(string m)
        {
            modelo = m;
        }
        public float getPonta()
        {
            return ponta;
        }
        public void setPonta( float p)
        {
            ponta = p;
        }
        public void tampar()
        {
            tampada = true;
        }
        public void destampar()
        {
            tampada = false;
        }
        public void status()
        {
            Console.WriteLine("Uma caneta " + getModelo());
            Console.WriteLine("Ponta " + getPonta());
            Console.WriteLine("Está tampada? " + tampada);
        }
        public Caneta(string m, float p)
        {
            setModelo(m);
            setPonta(p);
            tampar();
        }
    }
}

using System;
using System.Linq.Expressions;

namespace _04ExercicioIMC
{
    internal class Pessoa
    {
        public double peso;
        public double altura;

        public double imc()
        {
            return peso / (altura * altura);
        }

        public string resultado(double imc)
        {
           if (imc <  18.5)
            {
                return "Abaixo do peso";
            }else if( imc > 18.5 &&  imc < 25)
            {
                return "Peso normal";
            }
            else if (imc > 25 && imc < 30)
            {
                return "Acima do peso";
            }
            else if (imc > 30 && imc < 35)
            {
                return "Obesidade I";
            }
            else if (imc > 35 && imc < 40)
            {
                return "Obesidade II";
            }
            else if (imc >= 40)
            {
                return "Obesidade III";
            }

            return null;
        }

        public void mensagem()
        {
            double obterImc = imc();
            string obterResultado  = resultado(obterImc);
            Console.WriteLine ("O seu IMC foi de "+ obterImc + " você está com "  + obterResultado);
           
        }

    }
}


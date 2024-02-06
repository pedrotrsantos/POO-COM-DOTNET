using System;


namespace orientacao_a_objetos
{
     class Carro
    {
        public string marca;
        public string modelo;
        public string cor;
        public string question;

        public void mensagem()
        {
            Console.WriteLine("Seu carro é: " + marca + " " + modelo + " " + cor);
        }

    }
}

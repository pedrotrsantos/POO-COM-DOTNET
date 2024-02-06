using System;

namespace orientacao_a_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Pedro";
            obj.idade = 21;
            obj.mensagem();

            Carro carro = new Carro();
            carro.marca = "Ford";
            carro.modelo = "Belina";
            carro.cor = "Dourada";
            carro.mensagem();
        }
    
    }
}

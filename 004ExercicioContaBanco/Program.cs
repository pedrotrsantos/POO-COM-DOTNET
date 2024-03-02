using _004ExercicioContaBanco;
using System;

class Program
{
    static void Main(string[] args)
    {
        ContaBanco c1 = new ContaBanco();
        c1.AbrirConta(TipoConta.Cc, "Tonin do Posto", 100);
        c1.Depositar(100);
        c1.Extrato();
        c1.Sacar(20);
        c1.Extrato();
        c1.Anuidade();
        c1.Extrato();

        ContaBanco c2 = new ContaBanco();
        c2.AbrirConta(TipoConta.Cp, "Jorgin Mecanico", 0);
        c2.Depositar(500);
        c2.Extrato();
        c2.Sacar(600);
        c2.Extrato();
        c2.Anuidade();
        c2.Extrato();

        ContaBanco c3 = new ContaBanco();
        c3.AbrirConta(TipoConta.Cp, "Seu Junior", 100);
        c3.Depositar(50);
        c3.Extrato();
        c3.Sacar(150);
        c3.Extrato();
        c3.Anuidade();
        c3.Extrato();
    }
}

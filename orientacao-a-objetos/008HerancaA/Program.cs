using _008HerancaA;
using System;

class Program
{
    static void Main(string[] args)
    {


        Aluno[] a = new Aluno[1];
        a[0] = new Aluno();
        a[0].GerarAluno();
        a[0].Status();
        a[0].PagarMensalidade(1000.00);
        a[0].Status();

        Bolsista[] b = new Bolsista[1];
        b[0] = new Bolsista();
        b[0].GerarAluno();
        b[0].Status();
        b[0].PagarMensalidade(0.0);
        b[0].Status();
        

        Professor[] p = new Professor[1];
        p[0] = new Professor();
        p[0].GerarProfessor();
        p[0].Status();
        p[0].ReceberAumento(1000.00);

        Funcionario[] f = new Funcionario[1];
        f[0] = new Funcionario();
        f[0].GerarFuncinario();
        f[0].Status();
        f[0].MudarTrabalho();
        f[0].Status();
        f[0].MudarTrabalho();
        f[0].Status();

    }
}
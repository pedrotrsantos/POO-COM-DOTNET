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

        Professor[] p = new Professor[1];
        p[0] = new Professor();
        p[0].GerarProfessor();
        p[0].StatusProfessor();
        p[0].ReceberAumento(1000.00);

        Funcionario[] f = new Funcionario[1];
        f[0] = new Funcionario();
        f[0].GerarFuncinario();
        f[0].StatusFuncionario();
        f[0].MudarTrabalho();
        f[0].StatusFuncionario();
        f[0].MudarTrabalho();
        f[0].StatusFuncionario();

    }
}
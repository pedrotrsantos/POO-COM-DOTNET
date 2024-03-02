using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004ExercicioContaBanco
{
    public class ContaBanco
    {
        public int NumConta { get; set; }
        protected TipoConta Tipo { get; set; }
        private string Dono { get; set; }
        private double Saldo { get; set; }
        private bool Status { get; set; }
        private double Limite { get; set; }

        public ContaBanco()
        {
            Saldo = 0;
            Status = false;
           
        }


        public void AbrirConta(TipoConta tipo, string dono, double limite)
        {

            var GerarConta = new Random();

            NumConta = GerarConta.Next(10000000, 99999999);
            Tipo = tipo;
            Dono = dono;
            Limite = limite;
            Status = true;
        }

        public void FecharConta()
        {
            if (Status == false)
            {
                Console.WriteLine("ERRO, ESSA CONTA NÁO ESTÁ ATIVA!");
            }
            else if (Saldo > 0)
            {
                Console.WriteLine("ERRO, TEM SALDO NA CONTA!");
            }
            else if (Saldo < 0)
            {
                Console.WriteLine("ERRO, TEM SALDO NEGATIVO EM SUA CONTA!");
            }
            else if (Saldo == 0)
            {
                Status = false;
                Console.WriteLine("A CONTA FOI FECHADA COM SUCESSO");
            }
        }

        public void Depositar(double valor)
        {
            if (Status == false)
            {
                Console.WriteLine("ERRO, ESSA CONTA NÁO ESTÁ ATIVA!");
            }
            else if (valor <= 0)
            {
                Console.WriteLine("ERRO, 'VALOR DE DEPÓSITO INVALIDO");
            }
            else
            {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (Status == false)
            {
                Console.WriteLine("ERRO, ESSA CONTA NÁO ESTÁ ATIVA!");
            } else if (valor <= 0 )
            {
                Console.WriteLine("ERRO, VALOR DE SAQUE INVÁLIDO!");
            }else if (valor > (Saldo + Limite))
            {
                Console.WriteLine("ERRO, O VALOR EXTRAPOLOU O SEU LIMITE DE SAQUE");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"SAQUE DE R$ {valor} realizado com sucesso");
            }
        }
        public void Anuidade()
        {
            if (Tipo == TipoConta.Cc)
            {
                Saldo -= 12;
            } else
            {
                Saldo -= 20;
            }
        }

        public void Extrato()
        {
            Console.WriteLine($@"
Nome: {Dono} 
Conta: {NumConta} 
Tipo: {Tipo} 
Status: { Status} 
Saldo: R$ {Saldo}
");


        }




    }
    public enum TipoConta
    {
        Cc = 1,
        Cp = 2
    }
}

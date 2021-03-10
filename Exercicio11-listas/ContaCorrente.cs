using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11_listas
{
    class ContaCorrente
    {
        private string agencia;
        private string conta;
        private string titular;
        public double Saldo { get; private set; } = 0.0;

        public string Agencia
        {
            get => agencia;
            set
            {
                if (value.Length < 6)
                    throw new Exception("Preencha todos os digitos da agência");

                agencia = value;
            }
        }

        public string Conta
        {
            get => conta;
            set
            {
                if (value.Length < 11)
                    throw new Exception("Preencha todos os digitos da conta");

                conta = value;
            }
        }
        public string Titular
        {
            get => titular;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha seu nome!");

                titular = value;
            }
        }

        public ContaCorrente(string agencia, string conta, string titular)
        {
            Agencia = agencia;
            Conta = conta;
            Titular = titular;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0.0)
                throw new Exception("Você não pode depositar um valor menor ou igual a 0!");

            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
                throw new Exception($"ERRO! Você possui apenas R${Saldo} na sua conta!");
            else if (valor <= 0)
                throw new Exception("Digite um valor positivo e diferente de 0 para sacar");

            Saldo -= valor;
        }
    }
}

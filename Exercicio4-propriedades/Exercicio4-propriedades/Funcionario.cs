using System;

namespace Exercicio4_exercicios_propriedades
{
    internal class Funcionario
    {
        private int codigo;
        private string nome;
        private string rg;
        private double salario;

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("O codigo não pode ser menor ou igual a zero");

                codigo = value;
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome é obrigatorio");

                nome = value;
            }
        }

        public string Rg
        {
            get => rg;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O RG é obrigatorio");

                rg = value;
            }
        }

        public double Salario
        {
            get => salario - Inss;
            set
            {
                if (value < 0)
                    throw new Exception("O salario não pode ser 0");

                salario = value;
            }
        }

        public double Inss
        {
            get => salario * 0.11;
        }
    }
}
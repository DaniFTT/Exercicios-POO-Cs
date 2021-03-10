using System;

namespace Exercicio5_exercicios_propriedades
{
    internal class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;

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

        public double Nota1
        {
            get => nota1;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("A nota só pode estar entre 0 e 10");

                nota1 = value;
            }
        }

        public double Nota2
        {
            get => nota2;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("A nota só pode estar entre 0 e 10");

                nota2 = value;
            }
        }

        public double Media
        {
            get => (nota1 + nota2) / 2;
        }
    }
}
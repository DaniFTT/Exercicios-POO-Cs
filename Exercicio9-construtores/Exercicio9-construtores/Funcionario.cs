using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9_construtores
{
    internal class Funcionario
    {
        #region propriedades

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
            get => salario;
            set
            {
                if (value < 0)
                    throw new Exception("O salario não pode ser 0");

                salario = value;
            }
        }

        #endregion propriedades

        public Funcionario(int codigo, string nome, string rg, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Rg = rg;
            Salario = salario;
        }

        public double GetInss() => salario * 0.11;

        public double GetSalario() => salario - GetInss();
    }
}
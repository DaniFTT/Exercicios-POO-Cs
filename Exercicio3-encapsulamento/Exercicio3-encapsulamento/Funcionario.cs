using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_encapsulamento2
{
    class Funcionario
    {
        private int codigo;
        private string nome;
        private string rg;
        private double salario;

        public int GetCodigo() => codigo;
        public string GetNome() => nome;
        public string GetRg() => rg;
        public double Getsalario() => salario;


        public void SetCodigo(int valor)
        {
            if (valor <= 0)
                throw new Exception("O codigo não pode ser menor ou igual a zero");
            else
                codigo = valor;
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("O nome é obrigatorio");

            this.nome = nome;
        }

        public void SetRg(string rg)
        {
            if (string.IsNullOrEmpty(rg))
                throw new Exception("O RG é obrigatorio");

            this.rg = rg;
        }

        public void SetSalario(double salario)
        {
            if (salario < 0)
                throw new Exception("O salario não pode ser 0");


            this.salario = salario;
        }


        public double GetInss() => salario * 0.11;


        public double GetSalario() => salario - GetInss();
    }
}

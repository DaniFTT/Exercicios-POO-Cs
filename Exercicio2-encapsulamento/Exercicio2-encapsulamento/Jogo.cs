using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_encapsulamento
{
    class Jogo
    {
        private int Codigo;
        private string Nome;
        private string Categoria;
        private DateTime DataDeLancamento;

        
        public void SetCodigo(int valor)
        {
            if (valor <= 0)
                throw new Exception("O codigo deve ser maior que 0");
            else
                Codigo = valor;
        }

        public int GetCodigo() => Codigo;


        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("O nome é obrigatorio");
            else
                Nome = nome;
        }

        public string GetNome() => Nome;


        public void SetCategoria(string categoria)
        {
            if (categoria != "ação" && categoria != "luta" && categoria != "tiro" && categoria != "esportes")
                throw new Exception("Digite uma das categorias listadas: ação, luta, tiro, esportes!");
            else
                Categoria = categoria;
        }

        public string GetCategoria() => Categoria;


        public void SetDate(DateTime data)
        {
            if (data > DateTime.Now.Date)
                throw new Exception("A data de lançamento não pode ser maior que a atual");
            else
                DataDeLancamento = data;
        }

        public DateTime GetData() => DataDeLancamento;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12_pilha
{
    class Pilha
    {
        private readonly int capacidade = 10;
        private string[] dados;
        private int topo = -1;

        public Pilha() 
        {
            dados = new string[capacidade];
        }

        public Pilha(int capacidade)
        {
            this.capacidade = capacidade;
            dados = new string[capacidade];
        }


        public int Tamanho()
        {
            return topo + 1;
        }

        // este método empilha um valor string na pilha
        public void Empilha(string p_valor, int posicao)
        {
            if (Tamanho() != capacidade)
            {
                topo++;
                dados[topo] = p_valor;
            }
            else
            {
                throw new Exception("A pilha está cheia!!!");
            }
        }

        // este método desempilha um valor da pilha
        public string Desempilha()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A pilha está vazia!!!");
            }
            else
            {
                string r = dados[topo];
                dados[topo--] = null;
                return r;
            }
        }

        // este método devolve o valor que está no topo
        public string RetornaTopo()
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha está vazia!!!");
            else
                return dados[topo];
        }
    }
}

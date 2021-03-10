using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12_pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Pilha minhaPilha = new Pilha(15);

            Console.WriteLine();
            do
            {
                try
                {
                    Console.Write("Digite: 1->Empilha 2->Desempilha " +
                    "3->Topo 4->tamanho 5->Listar 9->Sair: ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.Write("\nDigite um dado para empilhar: ");
                        string valor = Console.ReadLine();

                        Console.Write($"\nDigite a posição onde quer empilhar (0 até {minhaPilha.Tamanho()}) ");
                        int posicao = Convert.ToInt32(Console.ReadLine());

                        minhaPilha.Empilha(valor, posicao);
                        Console.WriteLine();
                    }
                    else if (opcao == 2)
                    {
                        string desempilhado = minhaPilha.Desempilha();
                        Console.WriteLine($"\nDesempilhado: {desempilhado}");

                        Console.WriteLine();
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("\nTopo: {0}",
                            minhaPilha.RetornaTopo());

                        Console.WriteLine();
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine("\nTamanho da pilha: {0}", minhaPilha.Tamanho());

                        Console.WriteLine();
                    }
                    //else if (opcao == 5)
                    //{
                    //    Console.WriteLine("\nListagem da pilha");
                    //    Pilha pilhaAuxiliar = new Pilha();

                    //    while (minhaPilha.Tamanho() > 0)
                    //    {
                    //        string aux = minhaPilha.Desempilha();

                    //        Console.WriteLine(aux);
                    //        pilhaAuxiliar.Empilha(aux);
                    //    }

                    //    while (pilhaAuxiliar.Tamanho() > 0)
                    //        minhaPilha.Empilha(pilhaAuxiliar.Desempilha());

                    //    Console.WriteLine();
                    //}
                    else if (opcao == 9)
                    {
                        Environment.Exit(0);
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("\nErro! " + erro.Message + "\n");
                }
            }
            while (opcao != 9);
        }
    
    }
}

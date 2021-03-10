using System;

namespace Exercicio2_encapsulamento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Enunciado

            /*
              Utilizando a classe jogo criada no exercício anterior, faça um programa que instancie até 10 jogos. Após efetuar os cadastros, exiba os dados em vídeo. Encapsule os atributos. Validações:

                Código -  (int)  ( > 0)
                Nome  - (string)  (obrigatório)
                Categoria – (string)  (válido apenas “ação”  “luta” “tiro” e “Esportes” )
                Data de lançamento -  (DateTime) (deve ser  inferior à data atual)
            */

            #endregion Enunciado

            Console.WriteLine("Crie Até 10 Jogos! \n\n");

            Jogo[] vetorJogo = new Jogo[10];

            for (int i = 0; i < 10; i++)
            {
                vetorJogo[i] = new Jogo();

                do
                {
                    try
                    {
                        Console.Write("Digite o código do jogo: ");
                        vetorJogo[i].SetCodigo(Convert.ToInt32(Console.ReadLine()));
                        break;
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }

                } while (true);

                do
                {
                    try
                    {
                        Console.Write("Digite o Nome do jogo: ");
                        vetorJogo[i].SetNome(Console.ReadLine());
                        break;
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }

                } while (true);

                do
                {
                    try
                    {
                        Console.Write("Digite a categoria do jogo (ação / luta / tiro / esportes: ");
                        vetorJogo[i].SetCategoria(Console.ReadLine());
                        break;
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }

                } while (true);

                do
                {
                    try
                    {
                        Console.Write("Digite a data de lançamento: ");
                        vetorJogo[i].SetDate(Convert.ToDateTime(Console.ReadLine()));
                        break;
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }

                } while (true);


                Console.WriteLine();
                Console.WriteLine("Digite N para parar");
                if (Console.ReadLine() == "N" || Console.ReadLine() == "n")
                    break;
            }

            for (int k = 0; k < 10; k++)
            {
                if (vetorJogo[k] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Código: {vetorJogo[k].GetCodigo()}");
                    Console.WriteLine($"Nome: {vetorJogo[k].GetNome()}");
                    Console.WriteLine($"Categoria: {vetorJogo[k].GetCategoria()}");
                    Console.WriteLine($"Data de Lançamento: {vetorJogo[k].GetData()}\n\n");
                }
            }

            Console.ReadLine();
        }
    }
}
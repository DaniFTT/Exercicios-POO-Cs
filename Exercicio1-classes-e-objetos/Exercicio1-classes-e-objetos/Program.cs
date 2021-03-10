using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio1_classes_e_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Crie uma classe chamada Jogo com seguintes atributos:
                Código -  (int)
                Nome  - (string)
                Categoria – (string)
                Data de lançamento -  (DateTime)

              Instancie um objeto da classe Jogo, preencha os seus atributos e exiba em vídeo os dados.
            */
            #endregion

            Jogo j = new Jogo();

            Console.Write("Digite o código do jogo: ");
            j.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o Nome do jogo: ");
            j.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite a Categoria do jogo: ");
            j.Categoria = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite o código do jogo: ");
            j.DataDeLancamento = DateTime.Parse(Console.ReadLine());


            Thread.Sleep(1000);
            Console.Clear();


            Console.WriteLine("JOGO CRIADO!\n");
            Console.WriteLine($"Código: {j.Codigo}");
            Console.WriteLine($"Nome: {j.Nome}");
            Console.WriteLine($"Categoria: {j.Categoria}");
            Console.WriteLine($"Data de Lançamento: {j.DataDeLancamento:dd/MM/yyyy}");

            Console.ReadKey();


        }
    }
}

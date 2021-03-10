using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8_sobrecarga
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ExibeNoCentroDaTela("Daniel Santos");
            ExibeNoCentroDaTela("Agora em  red", ConsoleColor.Red);
            Console.ReadLine();
        }

        private static void ExibeNoCentroDaTela(string texto)
        {
            Console.CursorLeft = ((Console.WindowWidth - texto.Length) / 2);
            Console.WriteLine(texto);
        }

        private static void ExibeNoCentroDaTela(string texto, ConsoleColor cor)
        {
            ConsoleColor corAtual = Console.ForegroundColor;
            Console.ForegroundColor = cor;
            ExibeNoCentroDaTela(texto);
            Console.ForegroundColor = corAtual;
        }
    }
}
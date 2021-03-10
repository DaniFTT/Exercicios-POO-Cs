using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericicio7_sobrecarga
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SomaDoisValores(5, 6));
            Console.WriteLine(SomaDoisValores(7.8, 6.6));
            Console.WriteLine(SomaDoisValores("7,3", "9,9"));
            Console.ReadLine();
        }

        private static int SomaDoisValores(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        private static double SomaDoisValores(double valor1, double valor2)
        {
            Convert.ToDouble(valor1);
            Convert.ToDouble(valor2);

            return valor1 + valor2;
        }

        private static double SomaDoisValores(string valor1, string valor2)
        {
            return Convert.ToDouble(valor1) + Convert.ToDouble(valor2);
        }
    }
}
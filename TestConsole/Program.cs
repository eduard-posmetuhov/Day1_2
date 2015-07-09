using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RootN;
using JaggetMass;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Введите степень корня:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("С помощью метода Ньютона root = {0}", Root.FindRoot(N, n, 15));
            Console.WriteLine("С помощью метода Math.Pow root = {0}", Math.Pow(N,(double)1/n));
            Console.ReadKey();
            int[][] vektor = new int[3][];
            vektor[0] = new[] { 1, 2, 3 };
            vektor[1] = new[] { 1, 7, 1 };
            vektor[2] = new[] { 1, 4, 5, 6 };
            JaggetSort.SortMax(vektor);
            for (int i = 0; i < vektor.Length; i++)
            {
                foreach (int j in vektor[i])
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

       
    }
}

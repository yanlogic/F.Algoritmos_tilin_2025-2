using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arreglopar = new int[10,5];
            int acumulador = 2;

            for (int i = 0; i < 10; i ++)
            {
                for (int j = 0; j < 5; j ++)
                {
                    arreglopar[i,j] = acumulador;
                    acumulador += 2;
                }

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arreglopar[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

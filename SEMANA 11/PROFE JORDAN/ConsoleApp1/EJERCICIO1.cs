using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EJERCICIO1
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++) //Para recorrer un arreglo se usa FOR
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nLista de números ingresados: ");
            foreach (int i in num)
                Console.Write(i + " ");
            Console.ReadKey();

        }
    }
}

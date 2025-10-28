using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EJERCICIO4
    {
        public static void Ejercicio4()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse( Console.ReadLine() );
            }
            Console.WriteLine("\nLista de pares: ");
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                    Console.WriteLine(num[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EJERCICIO2
    {
        static void Ejercicio2()
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };
            Console.WriteLine("Lista original: ");
            foreach(int i in num)
                Console.Write(i + " ");

            Console.Write("\nLista con reemplazos: ");
            for(int i = 0; i < num.Length; i++)
            { 
                if(num[i] < 0)
                    num[i] = 0;
                Console.Write(num[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

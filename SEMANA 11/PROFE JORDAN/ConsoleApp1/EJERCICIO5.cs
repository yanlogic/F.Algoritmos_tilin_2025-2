using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EJERCICIO5
    {
        public static void Ejercicio5()
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            int suma = 0;

            for(int i = 0; i < cant; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
                suma += num[i]; 
            }

            Console.Write("\nNúmeros ingresados: ");
            foreach (int i in num)
                Console.Write(i + " ");

            Console.WriteLine("\n\nSuma total: " + suma);
        }
    }
}

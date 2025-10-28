using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EJERCICIO7
    {
        public static void Ejercicio6()
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            Random rnd = new Random();
            Console.WriteLine("\nLista aleatoria: ");

            for (int i = 0; i < cant; i++)
            {
                num[i] = rnd.Next(1,51);
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("\nIngrese el número a buscar: ");
            int buscar = int.Parse(Console.ReadLine());
            bool b = false;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == buscar)
                {
                    b = true; 
                }

            }

            if (b == true)
                Console.WriteLine("Existe.");
            else
                Console.WriteLine("No existe");
        }
    }
}

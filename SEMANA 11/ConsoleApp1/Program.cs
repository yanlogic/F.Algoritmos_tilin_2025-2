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
            string[] Vocales = new string[5];

            for (int i = 0; i < Vocales.Length; i++)
            {
                Console.Write("Ingrese la letra número {0}: ", i);
                Vocales[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n");
                Console.Write("La letra es: " + Vocales[i] + "\n");
                Evaluar(Vocales[i]);
            }
        }

        static void Evaluar(string usuario)
        {
            string letra = usuario;
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("Su letra es una vocal.");
            }
            else
            {
                Console.WriteLine("Su letra no es una vocal.");
            }
        }
    }
}

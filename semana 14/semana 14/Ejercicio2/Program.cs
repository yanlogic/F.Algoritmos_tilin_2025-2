using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] arreglodatos = new string[3,2];

            arreglodatos[0, 0] = "CURSO: ";
            arreglodatos[1, 0] = "DOCENTE: ";
            arreglodatos[2, 0] = "PRECIO: ";

            for (int i = 0; i < 3; i++) 
            {
                Console.Write(arreglodatos[i, 0]);

                for (int j = 1; j < 2; j++) 
                {
                    Console.Write("");
                    arreglodatos[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("=== LISTADO ===");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(arreglodatos[i, 0]);

                for (int j = 1; j < 2; j++)
                {
                    Console.Write(arreglodatos[i, j]);

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

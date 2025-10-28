using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EJERCICIO6
    {
        public static void Ejercicio6()
        {
            string[] productos = new string[5];
            int registro = 0;

            for (int i = 0; registro < productos.Length; i++)
            {
                Console.WriteLine("Ingrese producto: ");
                string pro = Console.ReadLine();
                bool rep = false;

                for (int j = 0; j < pro.Length; j++)
                {
                    if (productos[j] == pro)
                    {
                        Console.WriteLine("Producto existente.\n");
                        rep = true;
                    }
                }

                if(rep == false)
                {
                    productos[registro] = pro;
                    registro++;
                    break;
                }
            }
            Console.WriteLine("\nLista de productos: ");
            foreach (string i in productos)
            {
                Console.WriteLine(i);
            }
        }
    }
}

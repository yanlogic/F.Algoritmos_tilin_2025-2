using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS ARREGLO BIDIMENSIONAL
            string[,] arregloNombres;

            //CONFIGURAR TAMAÑO DEL ARREGLO (#FILAS, #COLUMNAS)
            arregloNombres = new string[3,4];

            //DECLARAMOS OTRO ARREGLO
            int[,] arregloNumeros = { {0,1,2,3,4},{5,6,7,8,9},{10,11,12,13,14} }; //las llaves son el tamaño general del arreglo
            //                         0 1 2 3 4
            //                         5 6 7 8 9
            //                         10 11 12 13 14   <= así queda

            //HACEMOS RECORRIDO DE LAS FILAS
            for(int i = 0; i < arregloNumeros.GetLength(0); i++)
            {
                //Hacemos recorrido de las columnas
                for(int j = 0; j < arregloNumeros.GetLength(1); j++)
                {
                    Console.Write(arregloNumeros[i,j] + "\t");
                }
                //Salto de linea
                Console.WriteLine();
            }

        }
    }
}

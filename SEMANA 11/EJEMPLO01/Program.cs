using System;

namespace EJEMPLO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Formas de iniciar un arreglo
            string[] Nombres = new string[5] {"Juan", "Ricardo", "Maria", "Job", "Leo"};
            int[] Edad = new int[] { 1, 2, 3, 4, 5 };

            double[] precio = { 25.5, 20, 15.30, 41 };

            string[] apellidos = new string[5];

            for(int i = 0; i < apellidos.Length; i++) //Arreglo + .Length = tamaño del arreglo
            {
                Console.Write("Ingrese el apellido {0}: ", i); //"0" cambia segú el valor de "i"
                apellidos[i] = Console.ReadLine();      
            }

            Console.Write("\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hola, " + Nombres[i] + " " + apellidos[i] + "!");
            }

        }
    }
}

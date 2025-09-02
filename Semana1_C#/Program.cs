using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            Console.ReadKey();
            ejer2();
            Console.ReadKey();
        }

        static void ejer1()
        {
            string nombre, carrera; //Declarar variables
            Console.Write("Bom día. Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();
            Console.Write(nombre + ", bienvenido al curso de Fundamentos de algoritmos de la carrera " + carrera);
        }

        static void ejer2()
        {
            Console.Write("Ingrese su primer número: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su segundo número: ");
            int Num2  = Convert.ToInt32(Console.ReadLine());
            double division = Num1 / Num2;
            Console.WriteLine("La suma entre ambos números es: " + (Num1 + Num2));
            Console.WriteLine("La resta entre ambos números es: " + (Num1 - Num2));
            Console.WriteLine("La multiplicación entre ambos números es: " + (Num1 * Num2));
            Console.WriteLine("La división entre ambos números es: " + division);
        }
    }
}

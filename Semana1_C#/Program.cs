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
            Console.Write("\"Yanta\"");
        }

        static void ejer3()
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

        static void ejer4()
        {
            console.WriteLine("Ingrese un número decimal: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redon = (int)Math.Round(num);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1/3d);

            Console.WriteLine("Raiz 2: " + raiz2);
            Console.WriteLine("Redondeado: " + redon);
            Console.WriteLine("Al cubo: " + cubo);
            Console.WriteLine("Raiz 3: " + raiz3);
        }

        static void ejer5()
        {
            console.write("Ingrese su número: ");
            string num = Console.ReadLine();
            int entero = int.Parse(num);
            double deci = double.Parse(num);
            console.writeline("Resto: " + (entero % 2));
            console.writeline("División: " + (deci / 3));
        }
    }
}

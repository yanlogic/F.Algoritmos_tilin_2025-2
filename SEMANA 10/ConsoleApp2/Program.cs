using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BILICOTETA;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cajero c = new Cajero();
            int opc;
            string conti;

            do
            {
                Console.WriteLine("BIENVENIDO AL SISTEMA DE CAJERO\n");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Salir\n");

                do
                {
                    Console.Write("Ingrese una opción: ");
                    opc = int.Parse(Console.ReadLine());
                    if (opc <= 0 | opc > 4)
                    {
                        Console.WriteLine("Opción inválida. Ingrese nuevamente\n");
                    }

                }
                while (opc < 0 | opc > 4);

                switch (opc)
                {
                    case 1: Console.WriteLine("Saldo disponible: S/" + c.Consultar()); break;
                    case 2: c.Depositar(0); break;
                    case 3: c.Retirar(0); break;
                    case 4: return;
                }

                while (true)
                {
                    Console.WriteLine("\n¿Desea continuar? (S/N): ");
                    conti = Console.ReadLine();

                    if (conti != "s" & conti != "n")
                    {
                        Console.WriteLine("Error. Sólo se permiten 'S' o 'N'.");
                    }
                    else break;
                }
                Console.Clear();
            }
            while (conti == "s");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILICOTETA
{
    public class Cajero
    {
        double saldo = 1000;

        public double Consultar()
        {
            return saldo;
        }

        public void Depositar(double monto)
        {
            while(true)
            {
                Console.Write("\nIngrese el monto a depositar: ");
                string en = Console.ReadLine();
                try
                {
                    monto = Convert.ToDouble(en);

                    if (monto > 0)
                    {
                        saldo += monto;
                        Console.WriteLine("Depósito exitoso.");
                        break;
                    }
                    else
                    {   
                        Console.WriteLine("Error. Tiene que ser un depósito mayor a 0");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError. El depósito tiene que ser un monto válido");

                }
            }
        }
        public void Retirar(double monto)
        {
            while(true)
            {
                Console.Write("\nIngrese el monto a retirar: ");
                string en = Console.ReadLine();
                try
                {
                    monto = Convert.ToDouble(en);

                    if (monto <= saldo)
                    {
                        saldo -= monto;
                        Console.WriteLine("Retiro exitoso.");
                        break;
                    }
                    else if (monto < 0)
                    {
                        Console.WriteLine("Error. Tiene que ser un retiro mayor a 0");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Error. Saldo insuficiente");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nError. El retiro tiene que ser un monto válido");

                }
            }
        }
    }
}

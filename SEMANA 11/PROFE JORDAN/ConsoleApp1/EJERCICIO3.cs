using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EJERCICIO3
    {
        public static void Ejercicio3()
        {
            int[] num = { 10, 50, 6, 3, 7, 20 };
            int minimo = num[0];
            int maximo = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if(num[i] < minimo)
                    minimo = num[i];
                if(num[i] > maximo)
                    maximo = num[i];
            }
            Console.WriteLine("Máximo: " + maximo);
            Console.WriteLine("Mínimo: " + minimo);

            EJERCICIO3.Ejercicio3();
        }
    }
}

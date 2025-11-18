using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIO_SYSVENTAS
{
    public class ClaseMenu
    {
        //Menu Dinamico
        public static void MenuPrincipalEstatico()
        {
            string[] menuPrincipal = { "REGISTRAR", "VENTA", "REPORTE", "MODIFICAR", "SALIR" };

            int controlfila = 0, indice = 0;

            ClaseInterfaz.Interfaz();

            ConsoleKey tecla;

            for (int i = 0; i < menuPrincipal.Length; i++)
            {
                if (indice == i)
                {
                    Console.SetCursorPosition(controlfila, 3);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\t" + menuPrincipal[i] + "\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.SetCursorPosition(controlfila, 3);
                    Console.Write(" " + menuPrincipal[i]);
                }
                controlfila = controlfila + 10;

            }
            Console.SetCursorPosition(0, 32);

        }

        //Metodo para presentar el menu principal de manera estatica
        public static void MenuPrincipalEstatico()
        {
            string[] menuPrincipal = { "REGISTRAR", "VENTA", "REPORTE", "MODIFICAR", "SALIR" };

            int controlfila = 0, indice = 0;


            ConsoleKey tecla;

            for(int i = 0; i < menuPrincipal.Length; i++)
            {
                if (indice == i)
                {
                    Console.SetCursorPosition(controlfila, 3);
                    Console.BackgroundColor = ConsoleColor.Green; 
                    Console.ForegroundColor = ConsoleColor.Black; 
                    Console.Write("\t" + menuPrincipal[i] + "\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.SetCursorPosition(controlfila, 3);
                    Console.Write(" " + menuPrincipal[i]);
                }
                controlfila = controlfila + 10;

            }
            Console.SetCursorPosition(0, 32);

        }
    }
}

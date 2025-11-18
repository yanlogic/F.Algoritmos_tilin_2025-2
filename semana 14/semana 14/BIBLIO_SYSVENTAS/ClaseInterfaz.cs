using System;


namespace BIBLIO_SYSVENTAS
{
    public class ClaseInterfaz
    {
        //Toda la intefaz del programa irá acá :)
        public static void Interfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                                          ");
            Console.WriteLine("                                      SISTEMA DE VENTAS - DON PEPE                                        ");
            Console.WriteLine("                                                                                                          ");
            Console.ResetColor();

            //Creamos el espacio para el menu
            Console.SetCursorPosition(0, 4);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                                          ");
            Console.ResetColor();

            //Creamos el contorno izquierdo de la interfaz
            for (int i = 5; i < 30; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.ResetColor();
            }

            //Creamos el contorno derecho de la interfaz
            for (int i = 5; i < 30; i++)
            {
                Console.SetCursorPosition(105, i);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.ResetColor();
            }

            for (int i = 0; i <= 105; i++)
            {
                Console.SetCursorPosition(i, 30);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Write(" "); // Usa Write, no WriteLine
            }
            Console.ResetColor(); // <--- ¡Esto es lo que elimina tu línea fea!

        }
    }
}

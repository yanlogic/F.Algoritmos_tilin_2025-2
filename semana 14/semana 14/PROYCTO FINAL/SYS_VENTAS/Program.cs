/* 
* El sistema de ventas como proyecto final debe incluir:
* -> BIBLIOTECAS
* -> CLASES
* -> METODOS
* -> ESTRUCTURAS REPETITIVAS
* -> ESTRUCTURA CONDICIONALES
* -> ARREGLOS UNIDIMENSIONALES
* -> ARREGLOS BIDIMENSIONALES
* -> VARIABLES
* -> DIAGRAMAS DE FLUJO
*/

using System;
using BIBLIO_SYSVENTAS;

namespace SYS_VENTAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BIBLIO_SYSVENTAS.ClaseInterfaz.Interfaz();
            BIBLIO_SYSVENTAS.ClaseMenu.MenuPrincipalEstatico();
        }
    }
}

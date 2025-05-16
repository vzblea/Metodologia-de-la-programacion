using System;

namespace Practica_4
{
    public class LectorDeDatos
    {
        // Lee un número entero del teclado
        public static int numeroPorTeclado()
        {
            Console.Write("Ingrese un número entero: ");
            return int.Parse(Console.ReadLine());
        }

        // Lee un número real (double) del teclado
        public static double doublePorTeclado()
        {
            Console.Write("Ingrese un número real: ");
            return double.Parse(Console.ReadLine());
        }

        // Lee una cadena de texto del teclado
        public static string stringPorTeclado()
        {
            Console.Write("Ingrese una cadena de texto: ");
            return Console.ReadLine();
        }
    }
}

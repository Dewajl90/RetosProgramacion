using System;
/*
 * Escribe un programa que reciba un texto y transforme lenguaje natural a
 * "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
 *  se caracteriza por sustituir caracteres alfanuméricos.
 * - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
 *   con el alfabeto y los números en "leet".
 *   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
 */

namespace Reto__1__EL__LENGUAJE_HACKER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertText text = new ConvertText();
            text.Data();
        }
    }
}

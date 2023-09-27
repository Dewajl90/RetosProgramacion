using System;
/*
 * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.
 * Podrás configurar generar contraseñas con los siguientes parámetros:
 * - Longitud: Entre 8 y 16.
 * - Con o sin letras mayúsculas.
 * - Con o sin números.
 * - Con o sin símbolos.
 * (Pudiendo combinar todos estos parámetros entre ellos)
 */

namespace Reto_3_EL_GENERADOR_DE_CONTRASEÑAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneradorContraseña generarC = new GeneradorContraseña();
            generarC.MostrarContraseña(); 
            GeneradorContraseña generarC2 = new GeneradorContraseña();
            generarC2.MostrarContraseña();
        }
    }
}

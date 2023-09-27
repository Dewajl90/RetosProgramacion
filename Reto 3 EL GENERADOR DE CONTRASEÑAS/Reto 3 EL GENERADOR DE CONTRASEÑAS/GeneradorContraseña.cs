using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Reto_3_EL_GENERADOR_DE_CONTRASEÑAS
{
    internal class GeneradorContraseña
    {
        //variable: random para numero aleatorio
        static Random random = new Random();
        // variable: numerosYLetras que me contiene el alfabeto en mayúsculas, minúsculas, núemeros y algunos simbolos
        static string numerosYLetras = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ/*-+#$%&/()";


        public void MostrarContraseña()
        {
            Console.WriteLine($"La contraseña Generada es: {Generar()}");
        }//Metodo que Imprime en pantalla la contraseña 
        private string Generar()
        {
            //Variable: password para almacenar contraseña
            string password = "";
            //variable: tamaño para crear la dimención de la contraseña
            int tamaño = random.Next(8, 17);
            //variable: caracter es un número aleatorio que sera el caracter del string numerosyletras
            int caracter;
            //ciclo for que va hasta el tamaño aleatorio y con la variable caracter en  cada ciclo cambia de número
            for (int i = 0; i < tamaño; i++)
            {
                caracter = random.Next(0, 73);
                password += numerosYLetras[caracter];
            }
            return password;
        }
    }
}

﻿using System;
using  static System.Console;
using static System.Convert;

namespace Reto_3_EL_GENERADOR_DE_CONTRASEÑAS
{
    internal class GeneradorContraseña
    {
        #region Variables
        public int Lenght { get; set; }
        public bool Capital { get; set; }
        public bool Numbers { get; set; }
        public bool Symbols { get; set; }
        #endregion

        //variable: random para numero aleatorio
        static Random random = new Random();

        public void MostrarContraseña()
        {
            ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($"La contraseña Generada es: {Informacion()}");
        }//Metodo que Imprime en pantalla la contraseña 
        private string Informacion()
        {
            string opc, msg = "";
            int i=0;
            do
            {
                Console.WriteLine("Ingrese tamaño de la clave:");
                this.Lenght = ToInt32(ReadLine());
            } while (this.Lenght < 8 || this.Lenght > 16);

            Console.Write("Desea que contenga mayúsculas: S: Si N:No..");
            opc = ReadLine().ToUpper();
            if (opc.Equals("S"))
                this.Capital = Respuesta(opc);
            Console.Write("Desea que contenga números: S: Si N:No..");
            opc = ReadLine().ToUpper();
            if (opc.Equals("S"))
                this.Numbers = Respuesta(opc);
            Console.Write("Desea que contenga simbolos: S:Si N:No..");
            opc = ReadLine().ToUpper();
            this.Symbols = Respuesta(opc);

            while (i < this.Lenght)
            {
                if (this.Capital == true)
                {
                    msg += Generar(65, 90);
                    i++;
                    i = Validar(i);
                }
                else
                {
                    msg += Generar(97, 123);
                    i++;
                    i = Validar(i);
                }

                if (this.Numbers == true)
                {               
                    msg += Generar(48, 57);
                    i++;
                    i = Validar(i);
                }
                if (this.Symbols == true)
                {
                    msg += Generar(33, 47);
                    i++;                
                    i = Validar(i);
                }
            }
            return msg; 
        }
        private Char Generar(int rangoMin, int rangoMax)
        {         
            int num = random.Next(rangoMin, rangoMax);
            return  (char)num;
            
        }//genera  numero aleatori a partir de un rango y retorna la letra 
        private int Validar(int size)
        { 
             if (size == this.Lenght)
                return this.Lenght;
             return size;
        } //valida si el tamaño es igual a la cantidad de caracteres generadas
        private bool Respuesta( string opc) 
        {
            if (opc.Equals("S"))
                return  true;
           return false;
        }//confirma si la letra es s para true o n para false
    }
}

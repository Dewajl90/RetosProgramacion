using System;
using static System.Console;

namespace Reto__1__EL__LENGUAJE_HACKER
{
    internal class ConvertText
    {
        public string Text { get; set; }

        public ConvertText()
        {
            Console.Write("Ingrese Texto: ");//ingreso de texto 
            this.Text = ReadLine().ToUpper();
        }//Constructor
        public void Data() 
        {
            for (int i = 0; i < Text.Length; i++) 
            {           
                //WriteLine($"letra {i}: {ConvertT(Convert.ToString(Text[i]))}");
                Write($"{ConvertT(Convert.ToString(Text[i]))}");

            }
        }//Muestra el texto convertido
        private string ConvertT( string data) 
        {   
            
            switch (data)
            {
                case "A":
                    return "4";
                case "B":
                    return "I3";
                case "C":
                    return "[";
                case "D":
                    return ")";
                case "E":
                    return "3";
                case "F":
                    return "|=";
                case "G":
                    return "&";
                case "H":
                    return "#";
                case "I":
                    return "1";
                case "J":
                    return ",_|";
                case "K":
                    return ">|";
                case "L":
                    return "1";
                case "M":
                    return "/\\/\\";
                case "N":
                    return "^/";
                case "Ñ":
                    return "^/-";
                case "O":
                    return "0";
                case "P":
                    return "|*";
                case "Q":
                    return "(_,)";
                case "R":
                    return "I2";
                case "S":
                    return "5";
                case "T":
                    return "7";
                case "U":
                    return "(_)";
                case "V":
                    return "\\/"; 
                case "W":
                    return "\\/\\/";
                case "X":
                    return "><";
                case "Y":
                    return "j";
                case "Z":
                    return "2";
                case "1":
                    return "L";
                case "2":
                    return "R";
                case "3":
                    return "E";
                case "4":
                    return "A";
                case "5":
                    return "S";
                case "6":
                    return "b";
                case "7":
                    return "T";
                case "8":
                    return "B";
                case "9":
                    return "g";
                case "0":
                    return "o";
            }
            return " ";
        }//Convierte las letras
    }
}

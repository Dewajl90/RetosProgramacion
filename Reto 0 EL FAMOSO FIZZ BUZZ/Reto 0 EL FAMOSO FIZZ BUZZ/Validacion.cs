using System;
using static System.Console;

namespace Reto_0_EL_FAMOSO_FIZZ_BUZZ
{
    internal class Validacion
    {
        public int Number { get; set; }

        public void PrintNumbers()
        {
            string palabra;
            for (int i = 1; i < 101; i++)
            {                
                palabra = Multiplo(i);
                if (palabra != "") 
                {
                    WriteLine($" {palabra}");
                }else
                    WriteLine($" {i}");
            }
        }//Imprime los números del 1 al 100

        private string Multiplo(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FIZZBUZZ";
            }
            else if (num % 3 == 0)
            {
                return "FIZZ";
            }
            else if (num % 5 == 0)
            {
                return "BUZZ";
            }
            else
            {
                return "";
            }
        }
    }
}

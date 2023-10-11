using System;
using  static System.Console;
using static System.Convert;

/*
 * Escribe un programa que, dado un número, compruebe y muestre si es primo,
 * fibonacci y par.
 * Ejemplos:
 * - Con el número 2, nos dirá: "2 es primo, fibonacci y es par"
 * - Con el número 7, nos dirá: "7 es primo, no es fibonacci y es impar"
 */
namespace Reto_4_PRIMO__FIBONACCI_Y_PAR
{
    internal class Numero
    {
        public int NumeroUno { get; set; }

        public Numero()
        {
            ForegroundColor = ConsoleColor.Green;
            do
            {
                Write("Ingrese Numero (entry number): ");
                ForegroundColor = ConsoleColor.White;
                this.NumeroUno = ToInt32(ReadLine());
            } while (this.NumeroUno<2);         
        }

        public void Print()
        {
            ForegroundColor=ConsoleColor.White;
           WriteLine($"\t{this.NumeroUno} {Primo()}, {Fibonacci()} y {Par()}");           
        }
        private string Primo()
        { 
            int i;
            int contadorP=0;
            for ( i = 1; i < this.NumeroUno+1; i++)
            {
                if (this.NumeroUno % i == 0) 
                {
                    contadorP++;
                }
                if (contadorP == 3)
                {
                    i = this.NumeroUno;
                }
            }
            if (contadorP == 2)  
                return "Es primo (is a prime number)";
            return "No es primo (is not a prime number)";
            
        }
        private string Par() {
            if (this.NumeroUno % 2==0)
                return "Es par (is an even number).";
            return "No es par (is an odd number). ";
        }
        private string Fibonacci()
        {
            int num1=1, num2=1, sum=0;
            string msg="";
            while (true)
            {
                sum = num2 + num1;
                num1 = num2;
                num2 = sum;
                if (sum == this.NumeroUno)
                {
                     msg = "Es Fibonacci (is an Fibonacci number)";
                    break;
                }
                else 
                if (sum>this.NumeroUno){

                     msg = "No es Fibonacci (is not a Fibonacci number)";
                    break;
                }
            }
            return msg;
        }
    }
}

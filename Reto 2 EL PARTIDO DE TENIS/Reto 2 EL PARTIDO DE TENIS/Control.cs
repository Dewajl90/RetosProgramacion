using System;
using static System.Console;
using static System.Convert;

namespace Reto_2_EL_PARTIDO_DE_TENIS
{
    internal class Control
    {
        private string Puntojugador { get; set; }//set y get del punto jugador
        static  int contP1 = 0;
        static  int contP2 = 0;
         
        public Control()
        {
            this.Puntojugador = null;
        }

        public void Puntos() 
        {
            bool juegoterminado=false;
            do
            {
                Console.Write("Ingrese jugada: ");
                this.Puntojugador = Console.ReadLine().ToUpper();
            } while (Puntojugador!="P1"&& Puntojugador != "P2");
            

            while (juegoterminado==false) {
              
                if (Puntojugador == "P1")
                {
                    if (contP1 == 0)
                    {
                        contP1 = 15;
                    }
                    else
                        if (contP1 == 15)
                    {
                        contP1 = 30;
                    }
                    else
                        if (contP1 == 30)
                    {
                        contP1 = 40;
                    }
                    else
                    {
                        contP1+=5;
                    }
                }
                else
                {
                    if (contP2 == 0)
                    {
                        contP2 = 15;
                    }
                    else
                       if (contP2 == 15)
                    {
                        contP2 = 30;
                    }
                    else
                       if (contP2 == 30)
                    {
                        contP2 = 40;
                    }
                    else
                    {
                        contP2+=5;
                    }
                }
                juegoterminado=Imprimir();
                if (juegoterminado == false)
                {
                    Console.Write("Ingrese jugada: ");
                    this.Puntojugador = Console.ReadLine().ToUpper();
                }
            }
           
         }

        private bool Imprimir() 
        {
            WriteLine($"Jugador 1 \t Jugador 2");
        
            if (contP1 == 40 && contP2 == 40)
            {
                WriteLine($"\t Deuce");
                return false;
            }
            else
            if (contP1 - contP2 == 5)
            {
                WriteLine($"ventaja del Jugador 1");
                return false;
            }
            else
            if ((contP1 - contP2 == 10)||(contP1 >= 45 && contP2 <= 30))
            {
                WriteLine($"Ha ganado el Jugador 1");
                return true;
            }
            else
               if (contP2 - contP1 == 5)
            {
                WriteLine($"ventaja del Jugador 2");
                return false;
            }
            else
            if ((contP2 - contP1 == 10) || (contP2 >= 45 && contP1 <= 30))
            {
                WriteLine($"Ha ganado el Jugador 2");
                return true;
            }
            else
            {
                if (contP1 == 0)
                {
                    WriteLine($"   Love \t\t {contP2}");
                }
                else if (contP2 == 0)
                {
                    WriteLine($"   {contP1}\t\t Love");
                }
                else
                {
                    WriteLine($"   {contP1}\t\t {contP2}");
                }
            }
            return false;
        }
    }
}

using static  System.Console;
using static System.Convert;

namespace Reto_40_TABLA_DE_MULTIPLICAR
{
    internal class Table
    {
        public int Number { get; set; }

        public Table()
        {
            Write("Ingrese número:" );
            this.Number = ToInt32(ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < 11; i++) 
            {
                WriteLine($"{this.Number} x {i} ={this.Number * i}");
            }         
        }
    }
}

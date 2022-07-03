using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Function1
    {
        public void Go()
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 7*x*x-3*x+6;
            Console.WriteLine("y = 7*" + x + "*" + x + "-3" + "*" + x + "+6");
            Console.Write("y = " + y );
        }
    }
}




//                               2
//вычисления значения функции y=7x - 3x+6 при любом значении x

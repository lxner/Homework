using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_22_B
    {
        public void Go()
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            double x = 12*a*a+7*a-16;
            Console.Write("x = " + x);
        }
    }
}



// вычисления значения функции x=12a*a+7*a-16 при любом значении a
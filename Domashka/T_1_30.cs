using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_30
    {
        public void Go()
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());
            double z = x*x*x-2.5*x*y+1.78*x*x-2.5*y+1;
            Console.Write("Z = " + z );
        }
    }
}



// z = x^3 - 2,5xy + 1,78x^2 - 2,5y + 1 при любых значениях x и y
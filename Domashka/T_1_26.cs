using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_26
    {
        public void Go()
        {
            Console.Write("Введите радиус: ");
            double r = double.Parse(Console.ReadLine());
            double d = 2*r;
            Console.WriteLine("Диаметр равен = " + d);
        }
    }
}



// Дан радиус окружности, найти её диаметр. d = 2*r
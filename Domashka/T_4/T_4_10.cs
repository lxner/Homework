using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_10
    {
        public void Go()
        {
            Console.WriteLine("Радиус круга: ");
            double a = double.Parse(Console.ReadLine());
            double s1 = Math.PI*a*a; // площадь круга.
            Console.WriteLine("Сторона квадрата: ");
            double b = double.Parse(Console.ReadLine());
            double s2 = b*b; // плошадь квадрата.
            if (s1 > s2)
            {
                Console.WriteLine("Плошадь круга больше,чем площадь квадрата");
            }
            else
            {
                Console.WriteLine("Плошадь квадрата больше, чем площадь круга");
            }
                       
        }
    }
}

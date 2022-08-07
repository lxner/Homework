using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_8
    {
        public void Go()
        {
            Console.WriteLine("Дано расстояние в км: ");
            double a = double.Parse(Console.ReadLine());
            double d = 1000*a;
            Console.WriteLine("Дано расстояние в футах: ");
            double b = double.Parse(Console.ReadLine());
            double c = 0.45*b;
            if (d > c)
            {
                Console.WriteLine("Расстояние b (футы) меньше ");
            }
            else
            {
                Console.WriteLine("Расстояние a (км) меньше ");
            }
        }
    }
}
// 1 km - 1000 m
// 1 ft - 0.45 m
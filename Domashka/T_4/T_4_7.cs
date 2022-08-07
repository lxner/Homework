using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_7
    {
        public void Go()
        {
            Console.WriteLine("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("максимум: " + a);
                Console.WriteLine("Минимум: " + b);
            }
            else
            {
                Console.WriteLine("Максимум: " + b);
                Console.WriteLine("Минимум: " + a);
            }
        }
    }
}

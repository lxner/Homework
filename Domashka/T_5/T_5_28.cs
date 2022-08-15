using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_5_28
    {
        public void Go()
        {
            Console.WriteLine("Введите число a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i++)
            {

                double m = 1;
                double z = (m+m)*i; // произведение всех чисел от a до b
                double l = z + (a + b);
                Console.WriteLine(" " + l);
            }
        }
    }
}


// найти произведение всех чисел от a до b, a и b вводятся с клавиатуры
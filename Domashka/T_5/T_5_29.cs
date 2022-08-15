using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_5_29
    {
        public void Go()
        {
            Console.WriteLine("Введите число a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i++)
            {
                double z = ((i+b)/2);
                double x = z+i;
                Console.WriteLine(" " + x);
            }
        }
    }
}
// (a+b)/2

// найти среднее арифметическое всех чисел от a до b, a и b вводятся с клавиатуры
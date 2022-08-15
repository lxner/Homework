using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_5_27
    {
        public void Go()
        {
            Console.WriteLine("Введите число a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i++)
            {
                double z = (a+b)*(b-a+1)/2; // сумма чисел 
                Console.WriteLine(" " + z);
                break;
            }
        }
    }
} 
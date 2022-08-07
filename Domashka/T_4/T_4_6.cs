using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_6
    {
        public void Go()
        {
            Console.WriteLine("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("а больше b");
                Console.WriteLine("b меньше а");
            }
            else
            {
                Console.WriteLine("b больше а");
                Console.WriteLine("a меньше b");
            }
        }
    }
}
//Уместил задачи под буквой а) и б). В одну задачу.
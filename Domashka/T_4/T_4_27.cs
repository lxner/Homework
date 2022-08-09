using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_27
    {
        public void Go()
        {
            Console.WriteLine("Введите трёхзначное число");
            int a = int.Parse(Console.ReadLine());
            int z1 = a/100; // 1 цифра
            int z2 = (a/10)%10; // 2 цифра
            int z3 = a%100; // 3 цифра
            if (z1 > z3)
            {
                Console.WriteLine("Первая цифра больше, чем последняя.");
            }
            else if (z3 > z1)
            {
                Console.WriteLine("Последняя цифра больше, чем первая.");
            }
            else
            {
                Console.WriteLine("Ошибка, первая и последняя цифры одинаковы.");
            }
            if (z1 > z2)
            {
                Console.WriteLine("Первая цифра больше, чем вторая.");
            }
            else if (z1 < z2)
            {
                Console.WriteLine("Второая цифра больше, чем первая");
            }
            else
            {
                Console.WriteLine("Ошибка, первая и вторая цифры одинаковы. ");
            }
            
            
        }
    }
}


// первая или вторая  цифра больше?
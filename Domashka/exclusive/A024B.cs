using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class A024B
    {
        public void Go()
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0 || i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Сумма цифр которая делится на 5 или на 7 = " + sum);
        }
    }
}
// Даны натуральные числа от 1 до 50, найдите сумму тех из них которые делятся на 5 или на 7
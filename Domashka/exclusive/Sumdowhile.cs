using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Sumdowhile
    {
        public void Go()
        {
            int i = 0;
            int sum = 0;
            do
            {
                if (i % 5 == 0 || i % 7 == 0)
                {
                    sum = sum + i;
                }
                i++;
            }
            while (i <= 50);
            Console.WriteLine("Сумма= " + sum);
        }    
    }
}
// Даны натуральные числа от 1 до 50, найдите сумму тех из них которые делятся на 5 или на 7
// do while
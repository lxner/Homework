using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class AsumB
    {
        public void Go()
        {
            int sum = 0;
            Console.WriteLine("Введите число от а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число до b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                sum = sum + i;
                
            }
            Console.WriteLine("сумма чисел = " + sum);
        }
    }
}

// посчитать сумму от a до b

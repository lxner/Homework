using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class A57B
    {
        public void Go()
        {
            Console.WriteLine("Введите число от a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число до b: ");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++)
            {

                if (i % 5 == 0 && i % 7 == 0)
                {
                    sum = sum + i;
                }
                
            }
            Console.WriteLine("Сумма чисел которая делится на 5 и на 7: " + sum);
        }
    }
}
// sum = sum + i; -- cумма от а до Ь
// найти сумму от a До b тех чисел, которые делятся на 5 и на 7

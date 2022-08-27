using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_6
    {
        public void Go()
        {
            int count = 0;
            int sum = 0;
            Console.WriteLine("Введите, сколько всего чисел будет: ");
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            while(i <= a)
            {
                count = count + 1;
                Console.WriteLine("Введите число: ");
                int b = int.Parse(Console.ReadLine());
                sum = sum + b;
                i++;
            }
            Console.WriteLine("Сумма = " + sum);
            Console.WriteLine("Кол-во чисел:" + count);

        }
    }
}


// Дана не пустая последовательность целых чисел, оканчивающаяся нулём. Найти: кол-во всех чисел последовательности

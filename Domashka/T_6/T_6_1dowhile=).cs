using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_6_1dowhile__
    {
        public void Go()
        {
            int count = 0;
            int sum = 0;
            int i = 1;
            Console.WriteLine("Введите, сколько всего чисел будет: ");
            int a = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Введите число: ");
                int b = int.Parse(Console.ReadLine());
                sum = sum + b;
                count = count + 1;
                i++;
            }
            while (i <= a);
            Console.WriteLine("Сумма = " + sum);
            Console.WriteLine("Кол-во чисел: " + count);
        }
    }
}

// Дана не пустая последовательность целых чисел, оканчивающаяся нулём. Найти: сумму всех чисел последовательности и
// кол-во всех чисел последовательности

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_6_1while
    {
        public void Go()
        {
            int count = 0; // кол-во чисел
            int sum = 0; // сумма.
            int a;
            Console.WriteLine("Введите число: ");
            a = int.Parse(Console.ReadLine());
            sum = sum + a;
            count = count + 1;
            while (a != 0)
            {                             
                    Console.WriteLine("Введите число: ");
                    a = int.Parse(Console.ReadLine());
                    sum = sum + a;
                    count = count + 1;                              
            }
            Console.WriteLine("Сумма = " + sum);
            Console.WriteLine("Кол-во чисел: " + count);
        }
    }
}

// Дана не пустая последовательность целых чисел, оканчивающаяся нулём. Найти: кол-во всех чисел последовательности
// нужно что бы когда пользователь вводил 0 прога закрывалась 

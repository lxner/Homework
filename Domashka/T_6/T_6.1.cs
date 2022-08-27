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
            int i = 1;
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());                                 
            while(i <= n)
            {                             
                Console.WriteLine("Введите число: ");
                int b = int.Parse(Console.ReadLine());
                if (b % 10 == 0)
                {
                    break;
                }
                sum = sum + b;
                count = count + 1;
                i++;         
            }
            Console.WriteLine("Сумма = " + sum);
            Console.WriteLine("Кол-во чисел:" + count);
        }
    }
}


// Дана не пустая последовательность целых чисел, оканчивающаяся нулём. Найти: кол-во всех чисел последовательности
// нужно что бы когда пользователь вводил 0 прога закрывалась 
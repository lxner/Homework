using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.T_6
{
    internal class T_6_5for
    {
        public void Go()
        {

            Console.WriteLine("Введите число: ");
            int z = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 2; i <= 18; i++)
            {
                Console.WriteLine("Введите число a: ");
                int a = int.Parse(Console.ReadLine());
                if (a == z)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("кол-во одинаковых чисел = " + count);
        }
    }
}
/*
 * 1 йогурт я сравниваю его со следующим.
 * 1 1 3 1 = 2 одинаковых числа, т.к нужно найти начальное.
 * a-1
 */

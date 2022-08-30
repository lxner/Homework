using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_6_2_while
    {
        public void Go()
        {
            double count = 0;
            double sum = 0;
            double sred;
            while (true)
            {
                Console.Write("Введите число: ");
                double a = double.Parse(Console.ReadLine());
                if(a <= -1)
                {
                    break;
                }
                sum = sum + a; // сумма
                count = count + 1; // кол-во чисел
                sred = sum/count;
                Console.WriteLine("Среднее арифм: " + sred);

            }             
        }
    }
}

// Дана не пустая последовательность неотрицательных целых чисел, оканчивающаяся отрицательныи числом.
// Найти среднее арифм. всех чисел последовательности (без учета отрицательного числа)

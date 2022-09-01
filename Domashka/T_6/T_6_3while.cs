using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_6_3while
    {
        public void Go()
        {
            int sum = 0;          
            int a;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            sum = sum + a;           
            while (a % 2 != 0)
            {
                Console.Write("Введите число: ");
                a = int.Parse(Console.ReadLine());
                sum = sum + a;
            }
            sum = sum - a;
            Console.WriteLine("Сумма нечёт чисел: " + sum);
        }
    }
}


// Дана последовательность из n вещественных чисел. Первое число в последовательности нечётное 
// Найти сумму всех идущих подряд в начале последовательности нечетных чисел. (Условный оператор не использовать)
// a%2 !=0
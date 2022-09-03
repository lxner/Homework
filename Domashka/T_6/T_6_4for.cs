using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_6_4for
    {
        public void Go()
        {
            int count = 0;
            int a;
            Console.WriteLine("Введите число: ");
            a = int.Parse(Console.ReadLine());
            count = count + 1;
            for (int i = a; i <= 0; i ++)
            {
                Console.WriteLine("Введите число: ");
                a = int.Parse(Console.ReadLine());
                count = count + 1;
            }         
            count = count - 1;
            Console.WriteLine("Кол-во отрицательных чисел = " + count);
        }
    }
}


//  Дана послеловательность из п вещественных чисел. начинающаяся с
//  орицательного числа, Определить, какое количество отрицательных чисел
//  записано в начале послеловательности. Условный оператор не использовать
//   (a <= 0);
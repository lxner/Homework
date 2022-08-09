using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_24
    {
        public void Go()
        {
            Console.WriteLine("Введите двузначное число: ");
            int a = int.Parse(Console.ReadLine());
            int z = (a/10) + (a%10);
            if (z >= 10)
            {
                Console.WriteLine("сумма цифр а ялвяется двузначным числом");
            }
            else { Console.WriteLine("Ошибка, сумма цифр а не является двузначным числом"); }
            if (z > a)
            {
                Console.WriteLine("Сумма цифр больше числа a");
            }
            else if (z == a)
            {
                Console.WriteLine("Сумма цифр равна числу а");
            }
            else
            {
                Console.WriteLine("Ошибка, сумма цифр меньше числа а");
            }


        }
    }
}


// больше ли числа а, сумма его цифр
// сумма цифр больше числа а?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_2_12
    {
        public void Go()
        {
            Console.WriteLine("Введите число: ");
            double a = double.Parse(Console.ReadLine());
            double b = a % 10;
            Console.WriteLine("число едениц: " + b);
            double c = a / 10;
            Console.WriteLine("Число десятков: " + c);
            double d = a / 100;
            double e = b + c + d;
            Console.WriteLine("Сумма цифр: " + e);
            double f = b * c * d;
            Console.WriteLine("Произведение: " + f);
        }
    }
}



// Дано трёхзначное число. Найти
// а) число едениц в нём
// b) число десятков в нём
// с) сумму его цифр
// d) произведение его цифр

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
            int a = int.Parse(Console.ReadLine());

            int b = a%10;
            Console.WriteLine("число единиц: " + b);

            int c = (a/10)%10;
            Console.WriteLine("Число десятков: " + c);

            int d = a/100;
            Console.WriteLine("число сотен: " + d);

            int sum = b + c + d;
            int prod = b*c*d;
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение: " + prod);
           
        }
    }
}



// Дано трёхзначное число. Найти
// а) число едениц в нём
// b) число десятков в нём
// с) сумму его цифр
// d) произведение его цифр

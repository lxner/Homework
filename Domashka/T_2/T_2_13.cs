using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_2_13
    {
        public void Go()
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int c = a%10; // единицы
            int b = (a/10)%10; // десятки
            int d = a/100; // сотни
            Console.WriteLine("сотни " + d);
            Console.WriteLine("десятки " + b);
            Console.WriteLine("единицы " + c);
            int w = (c*100) + (b*10) + d;
            Console.WriteLine(w);

        }
    }
}


// Дано трёхзначное число. Найти число, полученное при прочтении его цифр справа налево 

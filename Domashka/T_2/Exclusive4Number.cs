using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Exclusive4Number
    {
        public void Go()
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int b = a%10; // единицы
            int c = (a%100)/10; // десятки
            int d = (a%1000)/100; // сотни
            int h = a/1000; // тысячи
            Console.WriteLine("тысячи " + h);
            Console.WriteLine("сотни " + d);
            Console.WriteLine("десятки " + c);
            Console.WriteLine("единицы: " + b);
            int sum = h + d + c + b;
            Console.WriteLine("Сумма цифр: " + sum);
            int mus = (b*1000)+(c*100)+(d*10)+h;
            Console.WriteLine("Число задом наперёд: " + mus);
        }

    }
}

// Console.WriteLine("Число задом наперёд: " + mus);
// дано 4х-значное число, найти сумму его цифр и вывести число, которое получено задом наперед
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_2_10
    {
        public void Go()
        {
            Console.WriteLine("Введите число: ");
            double p = double.Parse(Console.ReadLine());
            double a = p / 10;
            Console.WriteLine("Число десятков в числе: " + a);
            double b = p % 10 ;
            Console.WriteLine("Число единиц: " + b);
            double k = a + b;
            Console.WriteLine("сумма: " + k);
            double l = a * b;
            Console.WriteLine("произведение: " + l);
        }
    }
}



//  дано двузначное число, найти:
// a) число десятков в нём
// b) число единиц в нём 
// c) сумму его цифр 
// d) произведение его цифр
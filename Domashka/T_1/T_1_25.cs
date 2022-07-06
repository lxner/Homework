using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_25
    {
        public void Go()
        {
            Console.Write("Введите сторону квадрата: ");
            double a = double.Parse(Console.ReadLine());
            double p = 4*a;
            Console.Write("Периметр квадрата = " + p);

        }
    }
}


// Дана сторона квадрата. Найти его периметр. P=4*a.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_28
    {
        public void Go()
        {
            Console.Write("Введите длину ребра куба: ");
            double r = double.Parse(Console.ReadLine());
            double s = 6*r*r;
            Console.WriteLine("Площадь боковой поверхности куба: " + s);
            double v = r*r*r;
            Console.Write("Обьем куба: " + v);
        }
    }
}



// Дана длина ребра куба. Найти обьем куба и площадь его боковй поверхности

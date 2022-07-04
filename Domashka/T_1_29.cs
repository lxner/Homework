using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_29
    {
        public void Go()
        {
            Console.Write("Введите радиус окружности: ");
            double r = double.Parse(Console.ReadLine());
            double d = 2*3.1415*r;
            Console.WriteLine("Длина окружности равна: " + d);
            double s = 3.1415*r*r;
            Console.WriteLine("Плошадь круга равна: " + s);
        }
    }
}



// дан радиус окружности. Найти длину окружности и площадь круга.
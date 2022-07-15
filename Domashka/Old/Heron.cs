using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Heron
    {
        public void Go() // пользователь вводит 3 стороны треугольника, нужно вывести площадь треугольника
        {
            Console.Write("сторона а = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("сторона b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("сторона c = ");
            double c = double.Parse(Console.ReadLine());
            
            double p = 0.5*(a + b + c); // полу-периметр
            if (p < 0 || p - a < 0 || p - b < 0 || p - c < 0)
            {
                Console.WriteLine("Треугольник с такими сторонами не существует");
            }
            else
            {
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Площадь равна: " + s);
            }
            
        }
    }
}

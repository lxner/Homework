using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_11
    {
        public void Go()
        {
            Console.WriteLine("Объём 1 тела: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Масса 1 тела: ");
            double a1 = double.Parse(Console.ReadLine());
            double p1 = a1/a; // плотность 1 тела.
            Console.WriteLine("Объём 2 тела: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Масса 2 тела: ");
            double b2 = double.Parse(Console.ReadLine());
            double p2 = b2/b; // плотность 2 тела.
            if (p1 > p2)
            {
                Console.WriteLine("Материал 1 тела имеет большую плотность");
            }
            else
            {
                Console.WriteLine("Материал 2 тела имеет большую плотность");
            }
            Console.WriteLine(p1); // test
            Console.WriteLine(p2); // test 
        }
    }
}

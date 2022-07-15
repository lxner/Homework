using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Square
    {
        public void Go()
        {
            //пользователь вводит сторону квадрата, нужно вывести площадь квадрата
            // S = a × a, где S — площадь, a — сторона.
            Console.Write("Введите сторону квадрата(a):");
            double a = double.Parse(Console.ReadLine());
            double s = a * a;
            Console.Write("s= " + a + "*" + a);
            Console.WriteLine("; S=" + s);
            //Console.ReadKey();

            //Console.Readkey решил по приколу написать
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_31
    {
        public void Go()
        {
            Console.WriteLine("Введите число (целое)(1): ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число (целое)(2): ");
            double b = double.Parse(Console.ReadLine());
            double c = (a + b)/2;
            Console.WriteLine("Среднее арифмитическое = " + c);
            double d = a*b;
            double e = Math.Sqrt(d);
            Console.WriteLine("Среднее геометрическое= " + e);
        }
    }
}


// даны два целых чилса. Найти
// а) среднее арифмитическое
// б) их среднее геометрическое.

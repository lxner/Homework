using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_39B
    {
        public void Go()
        {
            Console.WriteLine("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y = ");
            double y = double.Parse(Console.ReadLine());
            double q = 2.8*Math.Sin(x)+Math.Abs(y);
            Console.Write("q = " + q);
        }
    }
}

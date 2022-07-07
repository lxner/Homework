using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_39
    {
        public void Go()
        {
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());
            double z = x+(2+y/x*x)/y+(1/Math.Sqrt(x*x+10));
            Console.WriteLine("z = " + z);

        }
    }
}

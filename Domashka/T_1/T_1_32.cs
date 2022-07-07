using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_32
    {
        public void Go()
        {
            Console.WriteLine("Объём: ");
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine("масса тела: ");
            double m = double.Parse(Console.ReadLine());
            double a = m/v;
            Console.WriteLine("Плотность материала этого тела равна: " + a);
        }
    }
}

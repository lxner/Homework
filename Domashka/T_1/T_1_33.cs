using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_33
    {
        public void Go()
        {
            Console.WriteLine("Количество жителей: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Плошадь территории: ");
            double b = double.Parse(Console.ReadLine());
            double c = a/b;
            Console.WriteLine("Плотность населения равна: " + c);
        }
    }
}


// Известно кол-во жителей в государстве и плошадь его территории. Определить плотность населения в этом гос-ве.
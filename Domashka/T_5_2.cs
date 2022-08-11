using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_5_2
    {
        public void Go()
        {
            Console.WriteLine("Введите число: ");
            double a = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.Write( " " + a + " " );
            }

        }
    }
}

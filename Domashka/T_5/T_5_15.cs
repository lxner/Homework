using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_5_15
    {
        public void Go()
        {
            Console.WriteLine("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                int z = i*n;
                Console.WriteLine(i + " * " + n + "= " + z);
            }
        }
    }
}

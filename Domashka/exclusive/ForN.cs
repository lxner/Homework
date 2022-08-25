using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class ForN
    {
        public void Go()
        {
            Console.WriteLine("Введите число повторений N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x_ ");
            }
        }
    }
}

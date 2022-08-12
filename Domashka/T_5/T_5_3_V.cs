using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_5_3_V
    {
        public void Go()
        {
            Console.WriteLine("Введите чило a: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i <= 50; i++)
            {
                int z = i*i*i;
                Console.WriteLine(z);
            }

        }
    }
}

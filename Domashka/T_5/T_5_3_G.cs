using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_5_3_G
    {
        public void Go()
        {
            Console.WriteLine("Введите число от а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число до b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {        
                Console.WriteLine(" " + i);
            }
        }
    }
}

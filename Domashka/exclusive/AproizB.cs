using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class AproizB
    {
        public void Go()
        {
            Console.WriteLine("Введите число от a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число до b: ");
            int b = int.Parse(Console.ReadLine());
            int proizv = 1;            
            for (int i = a; i <= a; i++)
            {

                proizv = proizv*i;
                    
                
            }
            Console.WriteLine("Произведение: " + proizv);
            
        }
    }
}

// посчитать произведение от a до b

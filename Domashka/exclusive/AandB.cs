using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class AandB
    {
        public void Go()
        {
            Console.WriteLine("Введите число от а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число до b: ");
            int b = int.Parse(Console.ReadLine());
            int proizv = -1;
            for (int i = a; i <= b; i++)          
            {
                proizv = proizv + 1;
                
            }
           
            Console.WriteLine("Кол-во чисел = " + proizv);
        }
    }
}
//  Посчитать количество чисел от a до b
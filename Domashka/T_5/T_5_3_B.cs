using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_5_3_B
    {
        public void Go()
        {
            Console.WriteLine("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                int z = i*i; // квадраты
                Console.WriteLine(z);
               
                
               
            }
        }
    }
}

// квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры. b >= 10

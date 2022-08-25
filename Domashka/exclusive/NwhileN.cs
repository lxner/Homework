using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class NwhileN
    {
        public void Go()
        {           
            Console.WriteLine("Число повторений n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                i++;
                Console.WriteLine("x_");
            }
        }
    }
}
// пользователь вводит n, нужно n раз вывести "x_" при помощи
// while
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// найти количество делителей каждого из целых чисел от 120 до 140
namespace Domashka
{
    internal class T_8_25
    {
        public void Go()
        {
            
            for (int i = 120; i <= 140; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("кол-во делителей " + i + " числа = " + count);
            }
        }
    }
}
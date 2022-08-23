using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class A34B
    {
        public void Go()
        {
            Console.WriteLine("Введите число от a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число до b: ");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {                                       
                    sum = sum + i;  // сумма цифр
                    count = count + 1; // кол-во цифр
                }               
            }
            int sred = sum/count;
            Console.WriteLine("Среднее от а и Ь тех чисел, которые делятся на 3 или на 4: " + sred);
        }
    }
}


// найти среднее от a До b тех чисел, которые делятся на 3 или на 4
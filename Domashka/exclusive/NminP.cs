using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.exclusive
{
    internal class NminP
    {
        public void Go()
        {
            int min = 0;
            int count = 0;
            int a;

            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            min = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Введите число: ");
                a = int.Parse(Console.ReadLine());
                if (a < min)
                {
                    min = a;
                }

            }
            Console.WriteLine("Минимальное: " + min);

        }
    }
}
// взял 1 банку, и минимум присвоил ей

// с клавиатуры вводятся n чисел, определить минимальное, его порядковый номер

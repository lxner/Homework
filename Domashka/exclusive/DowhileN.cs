using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class DowhileN
    {
        public void Go()
        {
            Console.Write("Введите число повторений: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                Console.WriteLine("x_ ");
                i++;
            } while (i < n);
            

            
        }
       
    }
}
// пользователь вводит n, нужно n раз вывести "x_" при помощи
//                  цикла do while


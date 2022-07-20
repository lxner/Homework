using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_2_14
    {
        public void Go()
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int b = a%10; // единицы
            int c = (a/10)%10; // десятки
            int d = a/100; // сотни
            int z = c*100 + b*10 + d;
            Console.WriteLine("Ответ: " + z);
        }
    }
}



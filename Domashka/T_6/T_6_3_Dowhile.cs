using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_6_3_Dowhile
    {
        public void Go()
        {
            int sum = 0;
            int a;
            do
            {
                Console.Write("Введите число: ");
                a = int.Parse(Console.ReadLine());
                sum = sum + a;
            }
            while (a % 2 != 0);
            sum = sum - a; // вычитаю чётное последнее число..
            Console.WriteLine("Сумма нечёт чисел: " + sum);
        } 
        
    }
}

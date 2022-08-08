using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_21
    {
        public void Go()
        {
            Console.WriteLine("Введите натуральное число: ");
            int a = int.Parse(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("Число чётное.");
            }
            else
            {
                Console.WriteLine("Ошибка, число нечётное.");
            }
            if ((a%10)*10/10==7)
            {
                Console.WriteLine("Число оканчивается на 7.");
            }
            else
            {
                Console.WriteLine("Ошибка, число не оканчивается на 7.");
            }
            
        }
    }
}


// Добавил else для более интересного  внешнего вида программы.
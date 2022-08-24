using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Aproizv3B
    {
        public void Go()
        {
            int proiz = 1;
            int tr = 0;
            
            Console.WriteLine("Введите от а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите до Ь: ");
            int b = int.Parse(Console.ReadLine());           
            for (int i = a; i <= b; i++)
            {
                if(i % 10 == 0)
                {
                    proiz = proiz * i; // произведение 
                    tr = i % 10; // числа которые оканчиваются на последнюю цифру
                   
                }               
            }
            Console.WriteLine("Произведение от а до b тех чисел которые оканчиваются на 3 = " + proiz);
        }

    }
}

// 
//  найти произведение от a до b тех чисел, которые оканчиваются на 3


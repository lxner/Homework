using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_9
    {
        public void Go()
        {
            Console.WriteLine("Введите скорость в км: ");
            double a = double.Parse(Console.ReadLine());         
            Console.WriteLine("Введит скорость в м.с: ");
            double b = double.Parse(Console.ReadLine());
            double z = a*1000/3600;
            if (z > b)
            {
                Console.WriteLine("Скорость в км больше ");
            }
            else
            {
                Console.WriteLine("Скорость в м.с больше ");
            }

        }
    }
}



// Известны две скорости, одна в километрах в час, другая - в метрах в секунду. Какая из скоростей больше?
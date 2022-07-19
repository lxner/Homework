using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_2_11
    {
        public void Go()
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int b = a%10; // единициы 
            int c = a/10; // десятки 
            double d = (b*10)+c;
            Console.WriteLine("Число наоборот:  " + d);
        }
    }
}



// Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа.
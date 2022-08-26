using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Whiledrobcs
    {
        public void Go()
        {
            int count = 0;
            double sum = 0;
            int i = 1;
            while(i <= 5)
            {
                Console.Write("Введите " + i + " число: ");
                double a = double.Parse(Console.ReadLine());
                sum = sum + a; // сумма чисел
                count = count + 1; // кол-во цифр
                double sred = sum/count;
                Console.WriteLine("Среднее " + i + " числа =" + sred);
                Console.WriteLine("");
                i++;

            }
            
        }
    }
}


// Написать программу, которая вводит с клавиатуры последовательность из пяти дробных чисел
//  и после ввода каждого числа выводит среднее арифмитическое полученной части последовательности.
// while 
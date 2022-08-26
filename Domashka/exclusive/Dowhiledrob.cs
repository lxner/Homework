using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Dowhiledrob
    {
        public void Go()
        {
            int count = 0;
            double sum = 0;
            int i = 1;
            do
            {
                Console.WriteLine("Введите число: ");
                double a = double.Parse(Console.ReadLine());
                count = count + 1; // кол-во цифр
                sum = sum + a; // сумма цифр
                double sred = sum/count;
                Console.WriteLine("Среднее " + i + " числа = " + sred);
                i++;
            }
            while (i <= 5);
        }
    }
}
// Написать программу, которая вводит с клавиатуры последовательность из пяти дробных чисел
//  и после ввода каждого числа выводит среднее арифмитическое полученной части последовательности.
// do while
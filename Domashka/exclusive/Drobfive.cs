using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Drobfive
    {
        public void Go()
        {   double count = 0;
            double sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Введите число (дробное): ");
                double a = double.Parse(Console.ReadLine());
                count = count + 1; // кол-во цифр
                sum = sum + a; // сумма цифр
                double sred = sum / count;
                Console.WriteLine("Среднее " + i + " числа = " + sred);

            }
        }
    }
}
//  Написать программу, которая вводит с клавиатуры последовательность из пяти дробных чисел
//  и после ввода каждого числа выводит среднее арифмитическое полученной части последовательности.





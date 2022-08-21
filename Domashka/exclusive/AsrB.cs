using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class AsrB
    {
        public void Go()
        {                      
            double count = 0;
            double sum = 0;
            Console.WriteLine("Введите кол-во чисел: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Введите число: ");
                double a1 = double.Parse(Console.ReadLine());            
                count = (count + 1); // кол-во цифр
                sum = sum + a1; // сумма цифр 
            }
            double sred = sum / count;
            Console.WriteLine("Среднее арифмитическое = " + sred);
            Console.WriteLine("Сумма цифр: " + sum);

        }
    }
    
} 
// 1 + 2 + 3 + 4 + 5 = 15 (сумма) / 5 (кол-во)
//  a1 + a2 + ... an
// ----------------
//       n
// пользователь вводит с клавиатуры n чисел, найти среднее арифмитическое 
//                               
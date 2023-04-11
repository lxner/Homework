using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// В двумерном массиве хранится информация о зарплате 20 человек за каждый месяц года
// (1 человека - в первой строке, второго во второй и т.д.). Составить программу для расчета
// общей зарплаты, полученной за год любым человеком, информация о зарплате которого представленна в массиве
namespace Domashka
{
    internal class T_12_41
    {
        public void Go()
        {
            int month = 12;
            int people = 20;
            Random rnd = new Random();
            int[,] arr = new int[people,month];
            for (int i = 0; i < people; i++)
            {
                for (int j = 0; j < month; j++)
                {
                    arr[i, j] = rnd.Next(1,500);
                }
            }
            for (int i = 0; i < people; i++)
            {
                for (int j = 0; j < month; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            Console.WriteLine("Выберите человека : ");
            int a = int.Parse(Console.ReadLine());
            for (int j = 0; j < month; j++)
            {
                sum+= arr[a, j];
            }
            Console.WriteLine("общая зп " + sum);
        }
    }
}

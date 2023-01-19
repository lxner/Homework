using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// В Москве самыми тёплыми являются дни с 15 июля до 15 августа, для проведения музыкального фестиваля
// необходимо выбрать 7 следующих подряд дней этого периода, которые были наиболее тёплыми за последние 10 лет
// (данные каждого года о температуре воздуха в указанный период имеются)

// с 15 июля по 15 августа прошло 31 день
namespace Domashka
{
    internal class T_12_110
    {
        public void Go()
        {
            Random random = new Random();
            int year = 10;
            int months = 31;
            int max_temp = 0;
            int[,] arr = new int[year,months];
            //step 1. Enter array
            for (int i = 0; i < year; i++)
            {
                for (int j = 0; j < months; j++)
                {
                    arr[i, j] = random.Next(5,35);   // temperature
                }
            }
            for (int i = 0; i < year; i++)
            {
                Console.Write(i + " год: " + "\n");
                for (int j = 0; j < months; j++)
                {
                    Console.WriteLine("Температура " + j + " дня " + arr[i,j] + " градусов\n");
                }
                Console.WriteLine();
            }



        }
    }
}

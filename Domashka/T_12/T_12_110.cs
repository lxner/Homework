using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            int[,] arr = new int[10, 30];
            Random r = new Random();
            // step 2. enter array
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    arr[i, j] = r.Next(10, 35);
                }
            }
            // step 3. Print array
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " год: " + "\n");
                for (int j = 0; j < 30; j++)
                {
                    Console.WriteLine("Температура " + j + " дня " + arr[i, j] + " градусов\n");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //step 4. ищу суммы по температурам, и дни максимальной жары
            int mj = 0;
            int max_temp = int.MinValue;
            for (int j = 0; j < 24; j++)
            {
                int sum = 0;
                int sumj = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum+= arr[i, j] + arr[i, j+1] + arr[i, j+2] + arr[i, j+3] + arr[i, j+4] + arr[i, j+5] + arr[i, j+6];
                }
                Console.WriteLine(sum);
                if (sum > max_temp)
                {
                    max_temp = sum;
                    mj = j;

                }
            }
            Console.WriteLine("Максимальная температура: " + max_temp);
            Console.WriteLine("была во днях " + mj + " " + (mj+2) + " " + (mj+3) + " " +  (mj+4) + " " + (mj+5) + " " + (mj+6));
        }
    }
}

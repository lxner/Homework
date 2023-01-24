using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            Random random = new Random();
            int year = 10;
            int months = 31;
            int[,] arr = new int[year, months];
            //step 1. Enter array   
            for (int i = 0; i < year; i++)
            {
                for (int j = 0; j < months; j++)
                {
                    arr[i, j] = random.Next(5, 35);   // temperature
                }
            }
            //step 2. Output array
            for (int i = 0; i < year; i++)
            {
                Console.Write(i + " год: " + "\n");
                for (int j = 0; j < months; j++)
                {
                    Console.WriteLine("Температура " + j + " дня " + arr[i, j] + " градусов\n");
                }
                Console.WriteLine();
            }
            //step3. Ищу максимальную температуру подряд за 7 дней, в периоде 10 лет
            int max = int.MinValue;
            int mi = 0;
            int mj = 0;
            int max_sum = int.MinValue;
            for (int i = 0; i < year; i++)
            {
                int sum = 0;
                for (int j = 0; j < months; j++)
                {
                    sum+= arr[i, j];

                    if (max < sum)
                    {
                        mi = i;
                        max = sum;                        
                    }
                    if (sum > max_sum)
                    {
                        max_sum = sum;
                        Console.WriteLine(j);
                    }
                    
                }
                //  Console.WriteLine(sum);
                Console.WriteLine(mj);
            }
            
            Console.WriteLine();
            Console.WriteLine(max);
            Console.WriteLine();
            Console.WriteLine("максимальная температура была в " + mi +  " году ");
        }
    }
}

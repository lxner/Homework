using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_8_16
    {
        public void Go()
        {
            // обьявляю переменные для работы с ними.
            Random random = new Random();
            int mi = 0;         // переменная координата, дабы я мог вне области видимости юзать i (наши работники)
            int max = -1000;   // в будущем для работы с максимумом
            int sum = 0;      // в будушщм для того что бы положить туда сумму нашего массива
            int maxsum = 0;  // в будушем будет для поиска максимальной суммы массива
            int mj = 0;     // переменная координата, дабы я мог вне области видимости юзать j (наши 3 квартала)
            int obsum = 0;
            // заполняем наш массив
            Console.WriteLine("Введите кол-во работников: ");
            int a = int.Parse(Console.ReadLine());
            int b = 3; //kvartal
            int[,] ar = new int[a, b];
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i+1 + " работник");
                for (int j = 0; j < b; j++)
                {

                    ar[i, j] = random.Next(0, 100);
                    Console.WriteLine(j+1 + " месяц: " + ar[i, j]);
                }
                Console.WriteLine();
            }
            int mes = 0;
            // работаем с массивом,
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    sum1 = sum1 + ar[i, 0];
                    sum2 = sum2 + ar[i, 1];
                    sum3 = sum3 + ar[i, 2];
                    sum = sum + ar[i, j]; // сумма всего массива
                    // находим максимум в таблице
                    if (ar[i, j] > max)
                    {
                        max = ar[i, j];
                    }
                    // находим общую зп
                    if (sum1 > sum2 && sum1 > sum3)
                    {
                        obsum = 1;
                    }
                    if (sum2 > sum1 && sum2 > sum3)
                    {
                        obsum = 2;
                    }
                    if (sum3 > sum1 && sum3 > sum2)
                    {
                        obsum = 3;
                    }
                    // конец поиска общей зп
                }
                // ппоиск номера работника, получившего за квартал наибольшую сумму
                if (sum > maxsum)
                {
                    maxsum = sum;
                    mi = i+1;
                }
                sum = 0;

            }
            Console.WriteLine("максимальная зп в таблице: " + max);
            Console.WriteLine("Порядковый номер работника получившего за квартал наибольшую сумму: " + mi);
            Console.WriteLine("Общая зп всех работников была в месяце: " + obsum);
        }
    }
}
// в каком месяце общая зарплата всех работников была максимальной.
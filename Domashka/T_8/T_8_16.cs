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
            int[,] ar = new int[a,b];
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i+1 + " работник");
                for (int j = 0; j < b; j++)
                {

                    ar[i,j] = random.Next(0,100);
                    Console.WriteLine(j+1 + " квартал: " + ar[i,j]);
                }
                Console.WriteLine();
            }
            // работаем с массивом,
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    sum = sum + ar[i, j]; // сумма всего массива
                    
                    // находим максимум в таблице
                    if (ar[i,j] > max)
                    {
                        max = ar[i, j];   
                    }
                    // ищем общую максимальную зп (в каком квартале)
                    if (sum > obsum)
                    {
                        obsum = sum;
                    }
                    // если наша общая сумма больше суммы, то вот, общая максимальная зп за квартал
                    if (obsum > sum)
                    {
                        mj = j;
                    }
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
            Console.WriteLine("Общая максимальная зарплата была в " + mj + " квартале");
        }
    }
}
// в каком месяце общая зарплата всех работников была максимальной.
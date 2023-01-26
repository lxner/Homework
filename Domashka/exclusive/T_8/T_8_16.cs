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
            int sum;
            int summ;
            Random rnd = new Random();
            int workerCount = 12;
            int monthCount = 3;
            int[,] arr = new int[workerCount, monthCount];
            int[] sum_by_worker = new int[monthCount];
            int[] sum_by_month = new int[workerCount];
            int max = int.MinValue;
            int maxx = int.MinValue;
            // шаг 1, заполняем массив зп.
            for (int i = 0; i < workerCount; i++)
            {
                Console.WriteLine(i + " работник: ");
                for (int j = 0; j < monthCount; j++)
                {
                    arr[i, j] = rnd.Next(0, 5);
                    Console.WriteLine(j+1 + " месяц: " + arr[i, j]); // сразу выводим на экран
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // шаг 2, считаем массивы сумм по месяцам, и по работникам
            for (int i = 0; i < workerCount; i++)
            {
                for (int j = 0; j < monthCount; j++)
                {
                    sum_by_worker[j] += arr[i, j];
                    sum_by_month[i] += arr[i, j];
                }

            }
            // шаг 3, вывожу суммы по работникам, и по месяцам
            for (int i = 0; i < sum_by_worker.Length; i++)
            {
                Console.Write(sum_by_worker[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < sum_by_month.Length; i++)
            {
                Console.Write(sum_by_month[i] + " ");
            }
            Console.WriteLine();

            // шаг 4, ищу максимальную зп в таблице.
            for (int i = 0; i < workerCount; i++)
            {
                for (int j = 0; j < monthCount; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            Console.WriteLine("максимальная зп в таблице: " + max);

            // шаг 5, ищу порядковый номер работника, получившего за квартал больщую сумму
            int mj = 0;
            for (int i = 0; i < sum_by_month.Length; i++)
            {
                if (sum_by_month[i] > maxx)
                {
                    maxx = sum_by_month[i];
                    mj = i+1;
                }
            }
            Console.WriteLine("порядковый номер работника, получившего за квартал больщую сумму: " + mj);
            // шаг 6, в каком месяце общая зп всех работников была максимальной
            int find = 0;
            for (int i = 0; i < sum_by_worker.Length; i++)
            {
                if (sum_by_worker[i] > max)
                {
                    max = sum_by_worker[i];
                    find = i+1;
                }
            }
            Console.WriteLine("в каком месяце общая зп всех работников была максимальной: " + find + " месяце");

        }
    }
}
// в каком месяце общая зарплата всех работников была максимальной.
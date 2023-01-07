using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.exclusive
{
    //есть таблица N на M, ее заполнить случайными числами от 1 до 100

    //для этой таблицы
    //1. вывести строку, в которой сумма всех чисел наибольшая, и вывести эту сумму
    //2. вывести столбец, в котором сумма всех чисел наибольшая, и вывести эту сумму
    internal class UltraExclusiveForSergeiZhurin
    {
        public void Go()
        {
            int sum = 0;
            int summ = 0;
            int mj = 0;
            int mi = 0;
            Random rnd = new Random();
            Console.WriteLine("enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            int[] sum_by_string = new int[m];
            int[] sum_by_column = new int[n];
            int max = int.MinValue;
            int maxx = int.MinValue;
            // шаг 1, заполняем массив.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 100);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // шаг 2, считаем массивы сумм по строкам, и столбцам
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum_by_column[j] += arr[i, j];
                    sum_by_string[i] += arr[i, j];
                }

            }
            // шаг 3, вывожу суммы по строкам, и столбцам
            Console.WriteLine("сумма по столбцам");
            for (int i = 0; i < sum_by_column.Length; i++)
            {
                Console.Write(sum_by_column[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("сумма по строкам");
            for (int i = 0; i < sum_by_string.Length; i++)
            {
                Console.Write(sum_by_string[i] + " ");
            }
            Console.WriteLine();
            // шаг 4, вывожу столбец, в котором сумма всех чисел наибольшая, и вывожу эту сумму
            for (int i = 0; i < sum_by_column.Length; i++)
            {
                if (max < sum_by_column[i])
                {
                    max = sum_by_column[i];
                    mj = i + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("максимальная сумма по столбцам: " + max);
            Console.WriteLine("Столбец, в котором сумма всех чисел была наибольшая: " + mj);
            // шаг 5, вывожу строку, в которой сумма всех чисел наибольшая, и вывожу эту сумму
            for (int i = 0; i < sum_by_string.Length; i++)
            {
                if (maxx < sum_by_string[i])
                {
                    maxx = sum_by_string[i];
                    mi = i + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("максимальная сумма по столбцам: " + maxx);
            Console.WriteLine("Столбец, в котором сумма всех чисел была наибольшая: " + mi);
        }
    }
}
//1. вывести строку, в которой сумма всех чисел наибольшая, и вывести эту сумму


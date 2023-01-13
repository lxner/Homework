using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Дан двумерный массив из пятнадцати строк и двух столбцов. Найти номера
// Двух соседних строк, сумма элементов в которых минимальна
namespace Domashka
{
    internal class T_12_109
    {
        public void Go()
        {
            int minsum = int.MaxValue;
            // step 1. initialize array
            int[,] arr = new int[22, 2];
            Random r = new Random();
            // step 2. enter array
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr[i, j] = r.Next(0, 10);
                }
            }
            // step 3. Print array
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //step 4. ищу номера двух соседних строк, сумма элементов в которых - минимальна
            int mi = 0;
            for (int i = 0; i < 15; i++)
            {
                int sum = 0;
                for (int j = 0; j < 2; j++)
                {
                    sum+= arr[i, j];

                }
                if (sum < minsum)
                {
                    minsum = sum;
                    mi = i;
                }
            }
            Console.WriteLine("минимальная сумма:" + minsum);
            Console.Write("столбцы с минимальной суммой:" + mi + " " + (mi+1));
        }
    }
}

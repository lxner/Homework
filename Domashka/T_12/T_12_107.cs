using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Дан двумерный массив из двух строк и пятнадцати столбцов. Найти номера
// Двух соседних столбцов, сумма элементов в которых минимальна
namespace Domashka
{
    internal class T_12_107
    {
        public void Go()
        {
            int minsum = int.MaxValue;
            // step 1. initialize array
            int[,] arr = new int[2,15];
            Random r = new Random();
            // step 2. enter array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    arr[i, j] = r.Next(0,10);
                }
            }
            // step 3. Print array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //step 4. ищу номера двух соседних столбцов, сумма элементов в которых - минимальна
            int mj = 0;
            for (int j = 0; j < 14; j++)
            {
                int sum = 0;
                for (int i = 0; i < 2; i++)
                {
                    sum+= arr[i, j] + arr[i, j+1];
                }
                if (sum < minsum)
                {
                    minsum = sum;
                    mj = j;
                }
            }
            Console.WriteLine("минимальная сумма:" + minsum);
            Console.Write("столбцы с минимальной суммой:" + mj + " " + mj+1);
        }
    }
}

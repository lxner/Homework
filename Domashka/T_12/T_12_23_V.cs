using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_12_23_V
    {
        public void Go()
        {
            Random rnd = new Random();
            Console.WriteLine("введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i > j && i+j> n-1)
                    {
                        a[i, j] = 1;
                    }
                    if (i < j && i+j< n-1)
                    {
                        a[i, j] = 1;
                    }

                    if (i == j || i + j == n-1)
                    {
                        a[i, j] = 1;
                    }

                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]+"   ");
                }
                Console.WriteLine();
            }
        }   
    }
}

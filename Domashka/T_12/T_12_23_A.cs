using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_12_23_A
    {
        public void Go()
        {
            Random rnd = new Random();
            int[,] arr = new int[7,7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = 1;
                    }
                    if (i+j == 7-1)
                    {
                        arr[i, j] = 1;
                    }
                }
            }
            
            //
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

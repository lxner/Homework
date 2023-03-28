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
            int[,] a = new int[7, 7];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || i == a.GetLength(0)-1)
                    {
                        a[i, j] = 1;
                    }
                    if ((i == 1 || i == 5) && (j >= 1 && j <= 5))
                    {
                        a[i, j] = 1;
                    }
                    if ((i==2 || i==4) && (j>=2 && j<=4))
                    {
                        a[i, j]=1;
                    }
                    if (i==3 && j==3)
                    {
                        a[i, j]=1;
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

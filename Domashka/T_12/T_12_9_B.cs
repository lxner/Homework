using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.T_12
{
    internal class T_12_9_B
    {
        public void Go()
        {
            int[,] arr = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(0, 25);
                }
            }
            Console.WriteLine("Исходный массив\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + " \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Обработанный массив\n");
            int temp = 0;
            int tempp = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    temp = arr[4, 4];
                    tempp = arr[0, 0];
                    arr[4, 4] = tempp;
                    arr[0, 0] = temp;
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

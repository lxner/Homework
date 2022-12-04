using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Sortmas
    {
        public void Go()
        {
            int min = 1000;
            Random rnd = new Random();
            int[] arr = new int[10];
            int swap = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 10);
                if (min > arr[i])
                {
                    min = arr[i];
                }

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[j];
                    }

                }
                Console.Write(arr[i] + " ");
                swap = arr[i];
                min = arr[i];
                arr[i] = swap;
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
            
        }
    }
}

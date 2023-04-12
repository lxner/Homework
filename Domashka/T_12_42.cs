using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_12_42
    {
        public void Go()
        {
            Random rnd = new Random();
            int vagon = 18;
            int mesta = 36;
            int[,] arr = new int[vagon, mesta];
            for (int i = 0; i < vagon; i++)
            {
                for (int j = 0; j < mesta; j++)
                {
                    arr[i, j] = rnd.Next(0, 2);
                }
            }
            for (int i = 0; i < vagon; i++)
            {
                for (int j = 0; j < mesta; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int count = 0;
            Console.WriteLine("В каком вагоне посчитать кол-во свободных билетов? ");
            int a = int.Parse(Console.ReadLine());
            for (int j = 0; j < mesta; j++)
            {
                if (arr[a, j] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("число свободных мест = " + count);
        }
    }
}

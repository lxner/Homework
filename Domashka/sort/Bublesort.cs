using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.sort
{
    internal class Bublesort
    {
        public void Go()
        {
            int[] bublik = { 2, 8, 3, 5, 1, 12 };
            for (int i = 0; i < bublik.Length; i++)
            {
                Console.Write(bublik[i] + " ");
            }
            // step 2
            int temp;
            for (int i = 0; i < bublik.Length; i++)
            {
                for (int j = 0; j < bublik.Length-1; j++)
                {
                    if (bublik[j] > bublik[j+1])
                    {
                        temp = bublik[j];
                        bublik[j] = bublik[j+1];
                        bublik[j+1] = temp;
                    }
                }
            }
            // step 3
            for (int i = 0; i < bublik.Length; i++)
            {
                Console.Write(bublik[i] + " ");
            }
        }
    }
}

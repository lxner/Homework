using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.sort
{
    internal class ChooseSort
    {
        public void Go()
        {
            int min;
            int temp;
            int[] sosiska = { 8, 2, 5, 4 , 1, 9};
           
            for (int i = 0; i < sosiska.Length; i++)
            {
                Console.Write(sosiska[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < sosiska.Length; i++)
            {
                min = i;
               
                for (int j = i+1; j < sosiska.Length ; j++)
                {
                    if (sosiska[j] < sosiska[min])
                    {
                        min = j;
                    }
                }
                temp = sosiska[min];
                sosiska[min] = sosiska[i];
                sosiska[i] = temp;
                
            }

            for (int i = 0; i < sosiska.Length; i++)
            {
                Console.Write(sosiska[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.sort
{
    internal class Insert
    {
        public void Go()
        {
            int index;
            int number;
            int[] mra = { 8, 2, 5, 4, 1, 9 };
            for (int i = 0; i < mra.Length; i++)
            {
                Console.Write(mra[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < mra.Length; i++)
            {
                index = i;
                number = mra[i];
                while (index > 0 && number < mra[index-1])
                {
                    mra[index] = mra[index - 1];
                    index--;
                }
                mra[index] = number;
            }
            for (int i = 0; i < mra.Length; i++)
            {
                Console.Write(mra[i] + " ");
            }
        }
    }
}

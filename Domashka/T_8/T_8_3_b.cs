using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_8_3_b
    {
        // T_8_4_B
        public void Go()
        {
            for (int i = 6; i >= 2; i--)
            {
                for (int j = 0; j < i-1; j++)
                {
                    Console.Write(i-j + " ");
                }
                Console.WriteLine();

            }
        }
    }
}

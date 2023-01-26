using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_8_4_G
    {
        
        public void Go()
        {
            for (int i = 20; i >= 16; i--)
            {
                for (int j = 0; j < i-15; j++)
                {
                    Console.Write(i+j + " ");
                }
                Console.WriteLine();

            }
        }
        
       
    }
}
// 20 21 22 23 24
// 19 20 21 22 
// 18 19 20
// 17 18
// 16

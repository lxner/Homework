using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.T_8
{
    internal class T_8_4_V
    {
        public void Go()
        {
            for (int i = 30; i >= 26; i--)
            {
                for (int j = 0; j <= i; j++)
                {          
                        Console.Write(i-j + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}

// 30
// 29 30
// 28 29 30
// 27 28 29 30
// 26 27 28 29 30
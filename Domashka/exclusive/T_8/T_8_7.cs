﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_8_7
    {
        public void Go()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i + "*" + j + "=" + i*j + "\t");
                }
                Console.WriteLine();
            }
        }
       
    }
}

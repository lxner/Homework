using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.T_8
{
    internal class T_8_4_V
    {
        static void p(int res)
        {
            for (int i = 26; i <= 30; i++)
            {
                Console.Write(res + " ");
                
            }
            Console.WriteLine();

        }
        public void Go()
        {
            for (int i = 30; i >= 26; i--)
            {
                for (int j = 0; 30-j >= i; j++)
                {
                    Console.Write(i + j + " ");
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
//for (int g = 30; g <= 30; g++)
//{
//    Console.Write(g + " ");
//}
//Console.WriteLine();
//for (int g = 29; g <= 30; g++)
//{
//    Console.Write(g + " ");
//}
//Console.WriteLine();
//for (int g = 28; g <= 30; g++)
//{
//    Console.Write(g + " ");
//}
//Console.WriteLine();
//for (int g = 27; g <= 30; g++)
//{
//    Console.Write(g + " ");
//}
//Console.WriteLine();
//for (int g = 26; g <= 30; g++)
//{
//    Console.Write(g + " ");
//}
//Console.WriteLine();
//Console.WriteLine();
//for (int i = 26; i <= 30; i++)
//{
//    for (int j = 0; j <= 5; j++)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}


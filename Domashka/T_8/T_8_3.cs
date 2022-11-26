using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Domashka
{
    
    internal class T_8_3
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

            //
            //for (int z = 6; z >= 2; z--)
            //{
            //    Console.Write(z + " ");
            //}
            //Console.WriteLine();
            //for (int z = 5; z >= 2; z--)
            //{
            //    Console.Write(z + " ");
            //}
            //Console.WriteLine();
            //for (int z = 4; z >= 2; z--)
            //{
            //    Console.Write(z + " ");
            //}
            //Console.WriteLine();
            //for (int z = 3; z >= 2; z--)
            //{
            //    Console.Write(z + " ");
            //}
            //Console.WriteLine();
            //for (int z = 2; z >= 2; z--)
            //{
            //    Console.Write(z + " ");
            //}
        }
        
    }
    
}
//void p(int i)
//{
//    for (int p = 6; p >= 2; p--)
//    {
//        Console.WriteLine(p);
//    }
//}
// 6 5 4 3 2
// 5 4 3 2
// 4 3 2
// 3 2 
// 2

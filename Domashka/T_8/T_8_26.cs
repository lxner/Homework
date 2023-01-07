using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// составить программу для графического изображения делимости чисел от 1 до n
// в каждой строке напечатать очередное число, и столько символов "+" сколько делителей у этого числа
// 1+
// 2++
// 3++
// 4+++
namespace Domashka
{
    internal class T_8_26
    {
        public void Go()
        {
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                Console.Write(i + "");
                for (int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                        Console.Write('+');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

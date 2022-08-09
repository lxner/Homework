using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_25
    {
        public void Go()
        {
            Console.WriteLine("Введите двузначное число: ");
            int a = int.Parse(Console.ReadLine());
            int z = (a/10) + (a%10);           
            if (z % 3 == 0)
            {
                Console.WriteLine("Сумма цифр кратна трём.");
            }
            else
            {
                Console.WriteLine("Сумма цифр не кратна трём.");
            }
            if (z % a == 0)
            {
                Console.WriteLine("Сумма цифр кратна числу а");
            }
            else
            {
                Console.WriteLine("Сумма цифр не кратна числу а");
            }
        }
    }
}




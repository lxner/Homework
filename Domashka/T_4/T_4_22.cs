using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_4_22
    {
        public void Go()
        {
            Console.WriteLine("Введите двузначное число: ");
            int a = int.Parse(Console.ReadLine());
            int ot = a/10; // 1 цифра.
            int to = a%10; // 2 цифра.
            if (ot > to || ot == to)
            {
                Console.WriteLine("Первая цифра больше, чем второая.");
                Console.WriteLine("Цифры одинаковы.");

            }
            else
            {
                Console.WriteLine("Вторая цифра больше, чем первая.");              
            }
           
 
            
        }
    }
}


// В данной задаче я не понял, почему если цифры одинаковы то при выводе в консоль у меня 1 строка говорит что: первая цифра больше, чем вторая
// а вторая строка пишет что цифры одинаковы (это понятно почему), но что делать с 1 строчкой когда вводишь одинаковые числа?. Надеюсь понял меня.

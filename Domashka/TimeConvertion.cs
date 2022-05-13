using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Вася шел из пункта А в пункт Б h часов m минут и s секунд,
// тебе нужно вывести сколько времени заняла дорога Васи:
// 1.в часах
// 2.в минутах
// 3.в секундах
namespace Domashka
{
    internal class TimeConvertion
    {
        public void Go()
        {
             Console.Write("Часов: ");
             double h = double.Parse(Console.ReadLine());
             Console.Write("Минут: ");
             double m = double.Parse(Console.ReadLine());
             Console.Write("Секунд:");
             double s = double.Parse(Console.ReadLine());
            Console.WriteLine();
             double tm = h * 60 + m;
             Console.WriteLine("минут: " + tm);
             double cs = tm * 60 + s;
             Console.Write("секунд: " + cs);
              









        }



    }
}

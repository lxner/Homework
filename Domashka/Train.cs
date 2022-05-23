using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Поезд выехал в h1 часов. Поездка заняла h2 часов (меньше 1 суток) 
// Во сколько часов поезд приехал на станцию назначения? Не забыть, что в 24:00 время обнуляется
// Часовые пояса не учитывать (счёт идет по Московскому времени)
namespace Domashka
{
    internal class Train
    {
        public void Go()
        {
            Console.Write("Поезд выехал h1: ");
            double h1 = double.Parse(Console.ReadLine()); 
            Console.Write("Поездка занимает h2: ");
            double h2 = double.Parse(Console.ReadLine());
            double priezd = h1 + h2;
            Console.Write("Поезд приехал в " + priezd + " часа(ов) MCK ");
            double reset = 24;
            double next;
            if (priezd > 24)     
            {
                priezd = reset*0 + priezd;
            }
        }
    }
}

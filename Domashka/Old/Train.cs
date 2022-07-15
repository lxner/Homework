using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Поезд выехал в h1 часов и m1 минут. Поездка заняла h2 часов и m2 минут (меньше 1 суток) 
// Во сколько часов и минут поезд приехал на станцию назначения? Не забыть, что в 24:00 время обнуляется
// Часовые пояса не учитывать (счёт идет по Московскому времени)
namespace Domashka
{
    internal class Train
    {
        public void Go()
        {
            //Вводим во сколько часов и минут выехал поезд
            Console.Write("Поезд выехал часов h1: ");
            double h1 = double.Parse(Console.ReadLine());
            Console.Write("минут m1: ");
            double m1 = double.Parse(Console.ReadLine());

            //Вводим сколько занимает поездка
            Console.Write("Поездка занимает h2: ");
            double h2 = double.Parse(Console.ReadLine());
            Console.Write("Поездка занимает m2 минут: ");
            double m2 = double.Parse(Console.ReadLine());

            //Прибавляем время выезда ко времени которое занимает поездка.          
            double priezdh = h1 + h2;
            double priezdm = m1 + m2;
            if (priezdm >= 60)
            {
                priezdh = priezdh + 1;
                priezdm = priezdm - 60;
            }
            if (priezdh >= 24)
            {
                priezdh = priezdh - 24;
            }
            Console.Write("Поезд прибывает в: " + priezdh + ":" + priezdm);
           
            
            
        }
    }
}

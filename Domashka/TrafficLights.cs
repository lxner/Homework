using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// работа светофора запрограмированна следующим образом: Начиная с полуночи (00:00)
// 3 минуты - горит зелёный свет
// 1 минуту - горит жёлтый
// 3 минуты - горит красный
// 1 минуту - Горит жёлтый
// затем, все начинается сначала. Дано вещественное число t, означающее время в минутах прошедшее от полуночи
// Определить, сигнал какого цвета горит в это время на светофоре 
namespace Domashka
{
    internal class TrafficLights
    {
        public void Go()
        {
            Console.Write("Минуты t: ");
            int t = int.Parse(Console.ReadLine());
            int wex = 0;
        }
    }
}

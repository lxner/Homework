using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// за первые 30 минут в интернет клубе нужно платить по 80 копеек в минуту, а дальше по 60 копеек.  
// Но если клиент работает больше  или равно 5 часов ему снижается дальнейшая плата до 50 копеек в минуту.
// Сидоров работает а часов b минут . сколько ему нужно заплатить?

namespace Domashka
{
    internal class InternetClub
    {
        public void Go()
        {
            Console.Write("Сидоров работает а часов: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Сидоров работает b минут: ");
            double b = double.Parse(Console.ReadLine());

            double oplata = 0; // Сколько Сидоров оплатит за время  проведенное в интернет клубе;
            double timeMinute = a*60 + b; //Сколько Сидоров работал в минутах;
            if (timeMinute < 30) // Вычисляет сколько платит Сидоров если он работает меньше 30 минут;
            {
                oplata = timeMinute*80; 

            }
            if (timeMinute >= 30 && timeMinute < 300) // Вычисляет сколько платит Сидоров если он работает от 30 минут до 5 часов (300 минут);
            {
                double money30 = 30*80; // это oплата за первые 30 минут в клубе;
                double timeSverh30Min = timeMinute - 30; //Сколько работал Сидоров свыше 30 минут;
                oplata = money30 + 60*timeSverh30Min; // Общая оплата;
            }
            if (timeMinute >= 300) // Вычисляет, сколько платит Сидоров если время проведённое в клубе больше ибо равна 5 часам (300 минут);
            {
                double timeSverh5h = timeMinute - 300; // Сколько работал Сидоров свыше 5 часов;
                oplata = 18600 + 50*timeSverh5h; // 18600 - Время за первые 5 часов;
            }

            Console.WriteLine("Сидоров оплатит: " + oplata);







        }
    }
}

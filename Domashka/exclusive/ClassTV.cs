using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Создайте класс телевизор. В нём есть поле текущий канал.
// Предусмотрите в нём возможность переключения каналов: следующий канал, предыдущий канал, переход к каналу по номеру.
// Учтите, что канал не может иметь отрицательный номер
namespace Domashka
{
    class TV
    {
        Random rnd = new Random();
        public int currentchanel;
        public TV()
        {
            currentchanel = rnd.Next(0,10);
        }
        public void NextChanel()
        {
            currentchanel++;
            if (currentchanel > 10)
            {
                Console.WriteLine("Ошибка, всего 10 каналов.");
                Console.WriteLine("канал номер 10");
                return;
                
            }
            Console.WriteLine("переключение на следующий канал");
            Console.WriteLine("Канал номер: " + currentchanel);
        }

        public void PastChanel()
        {
            currentchanel--;
            if (currentchanel < 0)
            {
                Console.WriteLine("Оишбка, отрицательных каналов не существует");
                Console.WriteLine("канал номер 0");
                return;
            }
            Console.WriteLine("Переключение на предыдущий канал");
            Console.WriteLine("Канал номер: " + currentchanel);
        }

        public void NumberofChanel()
        {
            Console.WriteLine("Введите номер канала: ");
            currentchanel = int.Parse(Console.ReadLine());
            if (currentchanel < 0 || currentchanel > 10)
            {
                Console.WriteLine("Максимальных каналов: 10, либо вы переключили на отрицательный канал (его не существует)");
                return;
            }
            Console.WriteLine("канал номер: " + currentchanel);
        }
    }

    internal class ClassTV
    {
        public void Go()
        {
            TV mychanel1 = new TV();
            mychanel1.NextChanel();
            mychanel1.NumberofChanel();
            mychanel1.NextChanel();
            mychanel1.PastChanel();

        }
    }
}

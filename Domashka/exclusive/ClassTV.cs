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
        private int channel;
        public TV()
        {
            channel = rnd.Next(0,10);
            Console.WriteLine("Вы на дефолт канале: " + channel);
            Console.WriteLine();
        }
        public void NextChannel()
        {
            channel++;
            if (channel > 10)
            {
                Console.WriteLine("Ошибка, всего 10 каналов.");
                Console.WriteLine("канал номер 10");
                return;
                
            }
            Console.WriteLine("переключение на следующий канал");
            Console.WriteLine("Канал номер: " + channel);
        }

        public void PastChannel()
        {
            channel--;
            if (channel < 0)
            {
                Console.WriteLine("Оишбка, отрицательных каналов не существует");
                Console.WriteLine("канал номер 0");
                return;
            }
            Console.WriteLine("Переключение на предыдущий канал");
            Console.WriteLine("Канал номер: " + channel);
        }

        public void NumberofChannel(int chanel)
        {
            if (channel < 0 || channel > 10)
            {
                Console.WriteLine("Максимальных каналов: 10, либо вы переключили на отрицательный канал (его не существует)");
                return;
            }
            channel = chanel;
            Console.WriteLine("переход к каналу по номеру " + chanel);
            Console.WriteLine("канал номер: " + channel);
        }
    }

    internal class ClassTV
    {
        public void Go()
        {
            TV mychanel1 = new TV();
            mychanel1.NextChannel();
            mychanel1.NumberofChannel(3);
            mychanel1.NextChannel();
            mychanel1.PastChannel();

        }
    }
}

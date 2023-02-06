using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Составить программу
// а) заменяющую значение любого элемента второго столбца двумерного массива на число 13
namespace Domashka
{
    internal class T_12_8
    {
        public void Go()
        {
            Random rand = new Random();
            int[,] arr = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(0,10);
                }
            }
            Console.WriteLine("исходный массив");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("результат: \n");
            Console.WriteLine("Введите номер строки которую нужно заменить: ");
            int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[l, 2] = 13;
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}

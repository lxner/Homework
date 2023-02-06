using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Составить программу
// b) заменяющую значение любого элемента двумерного массива на число b

namespace Domashka.T_12
{
    internal class T_12_8_B
    {
        public void Go()
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                }
            }
            Console.WriteLine("исходный массив");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("результат: \n");
            Console.WriteLine("Введите номер строки которую нужно заменить: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер столбца которого нужно заменить: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите само число: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[l, k] = x;
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

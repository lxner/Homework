using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// составить программу которая меняет два любых элемента
// двумернгого массива
namespace Domashka.T_12
{
    internal class T_12_10
    {
        public void Go()
        {
            // шаг 1, заполняем массив
            int[,] arr = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(0, 25);
                }
            }
            // шаг 2, выводим массив
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + " \t");
                }
                Console.WriteLine();
            }
            // шаг 3, работа с массивом, поменять местами
            Console.WriteLine("Обработанный массив\n");
            int temp = 0;
            int tempp = 0;
            Console.WriteLine("Введите откуда взять элемент из столбца: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите откуда взять элемент со строки: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите в какой столбец вставить: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите в какую строку вставить: ");
            int y = int.Parse(Console.ReadLine());
            temp = arr[a,b];
            arr[a, b] = arr[x, y];
            arr[x, y] = temp;
            Console.WriteLine();
          //  шаг 4, выводим обработанный массив
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}







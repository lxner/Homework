using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// поменять 2 числа в одномерном массиве
namespace Domashka
{
    internal class T_12_22
    {
        public void Go()
        {
            Random rn = new Random();
            int[] arr = new int[6];
            for (int i = 0; i < 6; i++)
            {
                arr[i] = rn.Next(1,25);
            }
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Откуда взять число (индекс)?: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("С каким числом поменять (индекс)?: ");
            int b = int.Parse(Console.ReadLine());
            int temp = 0;
            temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
            Console.WriteLine("Обработанный массив");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

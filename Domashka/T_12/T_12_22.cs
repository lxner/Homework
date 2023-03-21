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
            Console.WriteLine("С какого индекса взять первое число?: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("С какого индекса взять первое число?: ");
            int b = int.Parse(Console.ReadLine());
            int tempa = 0;
            int tempb = 0;
            for (int i = 0; i < 6; i++)
            {
                tempa = arr[a];
                arr[b] = tempa;
                tempb = arr[b];
                arr[a] = tempb;

            }
            Console.WriteLine("Обработанный массив");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

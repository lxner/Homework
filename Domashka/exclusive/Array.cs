using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Описать класс одномерный массив, содержащий его элементы и их количество, а
// также методы: вывода всех значений на экран, нахождения минимального элемента,
// нахождения максимального элемента.
namespace Domashka
{
    class MyArr
    {
        int[] arr;
        public int Length;

        public MyArr(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }
        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }

            get
            {
                return arr[index];
            }
        }
    }
    internal class Array
    {
        public void Go()
        {
            Random random = new Random();
            var arr1 = new MyArr(5);
            int count = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(0,100);
                Console.Write(arr1[i] + " ");
                count++;
            }
            Console.WriteLine("\nКол-во элементов в массиве: " + count + "\n");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (min > arr1[i])
                {
                    min = arr1[i];
                }
                if (max < arr1[i])
                {
                    max = arr1[i];
                }
            }
            Console.WriteLine("minimum: " + min);
            Console.WriteLine("maximum: " + max);
        }
    }
}

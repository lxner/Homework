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
        public int lenght;

        public MyArr(int size)
        {
            arr = new int[size];
            lenght = size;
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
        public void Enterar()
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0,100);
                
            }
        }
        public void Printar()
        {
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        public void FindMin()
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("минимальное: " + min);
        }
        public void FindMax()
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Максимальное: " + max);
        }
    }
    internal class Array
    {
        public void Go()
        {
            var ar1 = new MyArr(5);
            ar1.Enterar();
            ar1.Printar();
            ar1.FindMin();
            ar1.FindMax();
            Console.WriteLine("размер массива = " + ar1.lenght);
        }
    }
}

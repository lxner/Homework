using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class KompleTh
    {
        public void Go()
        {
            FileStream file = new FileStream("C:\\Dev\\FILES\\usermassive.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            Random random = new Random();
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] ar = new int[size];
            Console.WriteLine("Enter range from: ");
            int range_from = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter range before: ");
            int range_before = int.Parse(Console.ReadLine());
            // step 1, Pack array
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = random.Next(range_from,range_before);
            }
            Console.WriteLine();
            // step 2, Write array
            writer.WriteLine("array: ");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
                writer.Write(ar[i] + " ");
            }
            Console.WriteLine();
            // step 3, Work with array
            int res = 0;
            Console.WriteLine("Enter user element: ");
            int userelement = int.Parse(Console.ReadLine());
            writer.WriteLine();
            writer.WriteLine("user entered a number: " + userelement);
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i].Equals(userelement))
                {
                    res = ar[i];
                }
            }
            writer.Write("Result = " + res);
            writer.Close();
        }
    }
}

// Сформировать массив из случайных целых чисел в указанном
// пользователем диапазоне. Сообщить, есть ли в нем элемент, также
// указанный пользователем. Полученные данные сохранить в файл,
// предусмотреть использование пользовательского метода.
 
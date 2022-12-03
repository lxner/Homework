using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_8_14
    {
        static int checkRow(int[]ar, int n)
        {
            int count = 0;
            if (ar[n] > 2)
            {
                count++;
            }
            return count;
        }
        public void Go()
        {
            int dvoiki = 0;
            int count = 0;
            int countt = 0;
            int _count = 0;
            Random random = new Random();
            Console.WriteLine("кол-во студентов");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("кол-во предметов");
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            Console.WriteLine();
            for (int i = 0; i < a; i++)      // student
            {
                Console.WriteLine(i+1 + " студент ");
                for (int j = 0; j < b; j++)              // predmet
                {
                    array[i, j] = random.Next(2, 5);
                    Console.WriteLine(j+1 + " предмет: " + array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (array[i, j] > 2)
                    {
                        count++;
                    }
                    if (array[i, j] == 5 || array[i, j] == 4)
                    {
                        _count++;
                    }
                    if (array[i, j] == 2)
                    {
                        dvoiki++;
                    }
                }
                if (count == b)
                {
                    countt++;
                }
                count = 0;

            }
            Console.WriteLine("количество студентов, сдавших сессию без двоек: "+ countt);
            Console.WriteLine("кол-во предметов, по которым были получены оценки 5 или 4: " + _count);
            Console.WriteLine("кол-во двоек по каждому предмету: " + dvoiki);



            // кол-во двоек по каждому предмету


            //int count = 0;
            //Console.WriteLine("Введите n: ");
            //int n = int.Parse(Console.ReadLine());
            //Random random = new Random();
            //int[] arr = new int[n];
            //Console.WriteLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(1, 5);
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 3 && arr[i] > 0)
            //    {
            //        count++;
            //    }
            //
            //    if (count > 0)
            //    {
            //        Console.WriteLine("кол-во плохих оценок: " +  count);
            //    }

        }
    }
}
//Есть массив оценок (их N штук), тебе надо определить, есть ли в нем оценки 1 или 2

//N задается с клавиатуры, оценки заполняются случайно от 1 до 5

// Кол-во студентов  сдавших сессию без 2

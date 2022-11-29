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
        public void Go()
        {
            
            Random random = new Random();
            //for (int i = 1; i <= 15; i++)
            //{
            //    Console.WriteLine(i + " студент = ");
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine("оценка по " + j + " предмету = " + random.Next(1, 5));
            //        if (j != 2)
            //        {
            //            dvoikic++;
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Кол-во студентов сдавших сессию без 2 = " + dvoikic);

            // if (a[i][0]!=2 && a[i][1]!=2 && a[i][2]!=2)

            // заполняем массив
            //int i = 15;
            //int j = 3;
            //int[,] array = new int[i, j];
            //for (i = 0; i < array.GetLength(0); i++) //студенты
            //{
            //    Console.WriteLine(i + " Студент = ");   
            //    for (j = 0; j < array.GetLength(1); j++) //оценки
            //    {
            //        array[i, j] = random.Next(1,5);
            //        Console.WriteLine("оценка по " + array[i,j] + " предмету = " + array[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            //// работа с имеющщимеся данными
            //Console.WriteLine();
            //for (i = 0; i < array.GetLength(0); i++)
            //{

            //        // проверяю каждую оценку студента на 2
            //        if (array[i, 0] > 2 && array[i, 1] > 2 && array[i, 2] > 2)
            //        {
            //            count++;
            //        }

            //}
            //Console.WriteLine("Кол-во студентов сдавших сессию без 2 = " + count);
            int count = 0;
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Random random2 = new Random();
            int[] arr = new int[n];
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random2.Next(1,5);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 3 && arr[i] > 0)
                {
                    count++;
                    
                }
               
            }
            for (int i = 0; i < 1; i++)
            {
                if (count > 0)
                {
                    Console.WriteLine("кол-во плохих оценок: " +  count);

                }
            }
            

        }
    }
}
//Есть массив оценок (их N штук), тебе надо определить, есть ли в нем оценки 1 или 2

//N задается с клавиатуры, оценки заполняются случайно от 1 до 5

// Кол-во студентов  сдавших сессию без 2

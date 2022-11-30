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

            // if (a[i][0]!=2 && a[i][1]!=2 && a[i][2]!=2)

             // заполняем массив
             int count = 0;
            int i = 15;
            int j = 3;
            int[,] array = new int[i, j];
            for (i = 0; i < array.GetLength(0); i++) //студенты
            {
                Console.WriteLine(i + " Студент = ");
                for (j = 0; j < array.GetLength(1); j++) //оценки
                {
                    array[i, j] = random.Next(1, 5);
                    Console.WriteLine("оценка по " + (j+1) + " предмету = " + array[i, j]);
                }
                Console.WriteLine();
            }
            // работа с имеющщимеся данными
            Console.WriteLine();
            // int[] countt = new int[i];
            // проверяю каждую оценку студента на 2
            for (i = 0; i < array.GetLength(0); i++)   // student
            {

                for (j = 0; j < array.GetLength(1); j++)   // оценки
                {
                    
                    if (array[i,0] > 2 && array[i,1] > 2 && array[i,2] > 2)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("кол-во студентов сдавших без 2: " + count/3);

            //int count = 0;
            //Console.WriteLine("Введите n: ");
            //int n = int.Parse(Console.ReadLine());
            //Random random2 = new Random();
            //int[] arr = new int[n];
            //Console.WriteLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random2.Next(1, 5);
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 3 && arr[i] > 0)
            //    {
            //        count++;

            //    }

            //}
            //for (int i = 0; i < 1; i++)
            //{
            //    if (count > 0)
            //    {
            //        Console.WriteLine("кол-во плохих оценок: " +  count);
            //    }
            //}

        }
    }
}
//Есть массив оценок (их N штук), тебе надо определить, есть ли в нем оценки 1 или 2

//N задается с клавиатуры, оценки заполняются случайно от 1 до 5

// Кол-во студентов  сдавших сессию без 2

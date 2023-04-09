using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// В двумерном массиве хранится информация о количестве студентов
// в той или иной группе каждого курса института с первого по пятый
// (в первой строке — информация о группах первого курса, во второй —
// второго ит. д.). На каждом курсе имеется 8 групп. Составить програм-
// му для расчета общего числа студентов на любом курсе.
namespace Domashka
{
    internal class T_12_40
    {
        public void Go()
        {
            int sum = 0;
            int curs = 5;
            int group = 8;
            Random rnd = new Random();
            int[,] arr = new int[curs,group];
            for (int i = 0; i < curs; i++)
            {
                for (int j = 0; j < group; j++)
                {
                    arr[i,j] = rnd.Next(1,25);
                }

            }
            for (int i = 0; i < curs; i++)
            {
                for (int j = 0; j < group; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Выберите курс: ");
            int a = int.Parse(Console.ReadLine());
            for (int j = 0; j < group; j++)
            {
                sum+= arr[a, j];         
            }
            Console.WriteLine("Вы выбрали " + a + " курс ");
            Console.WriteLine("общее кол-во студентов = " + sum);
        }
    }
}
// Составить програм-
// му для расчета общего числа студентов на любом курсе

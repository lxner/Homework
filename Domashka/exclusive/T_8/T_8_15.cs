using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka.T_8
{
    internal class T_8_15
    {
        public void Go()
        {
            int max = -1000;
            int sum = 0;
            int maxsum = -1000;
            Random random = new Random();
            Console.WriteLine("Введите кол-во спортсменов: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во видов спорта: ");
            int b = int.Parse(Console.ReadLine());
            int[,] ar = new int[a, b];
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                Console.WriteLine(i + 1 + " спортсмен: ");
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    ar[i, j] = random.Next(0, 100);
                    Console.WriteLine(j + 1 + " вид спорта: " + ar[i, j] + " баллов");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {

                    if (ar[i, j] > max)   // максимальную из оценок в таблице
                    {
                        max = ar[i, j];
                    }
                    sum = sum + ar[i, j];
                }
                if (sum > maxsum)
                {
                    maxsum = sum;
                }
                sum = 0;
            }
            Console.WriteLine("максимальная из оценок в таблице: " + max);
            Console.WriteLine("победитель соревнований набрал: " + maxsum + " баллов");
            // сколько балов набрал победитель соревнований
            // победитель соревнования тот участник, у которого сумма баллов по всем соревнованиям максимальная
        }

    }
}

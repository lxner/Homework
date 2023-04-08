using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// в зрительном зале 25 рядов, в каждом из которых 36 мест (кресел)
// информация о проднных билетах хранится в двумерном массиве, номера строк
// которого соотвествует номерам рядов, а номерам столбцов - номерам мест
// если билет на то или иное место продан, то соотвествующий элемент массива имеет значение 1
// в противном случае - 0. Составить программу, определяющую число проданных билетов на места в 12 ряду
namespace Domashka
{
    internal class T_12_39
    {
        public void Go()
        {
            Random rnd = new Random();
            int ryad = 25;
            int mesta = 36;
            int[,] arr = new int[ryad, mesta];
            for (int i = 0; i < ryad; i++)
            {
                for (int j = 0; j < mesta; j++)
                {
                    arr[i, j] = rnd.Next(0, 2);
                }
            }
            for (int i = 0; i < ryad; i++)
            {
                for (int j = 0; j < mesta; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int count = 0;
            for (int j = 0; j < mesta; j++)
            {
                if (arr[12, j] == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("число проданных мест в 12 ряду = " + count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_8_16
    {
        public void Go()
        {
            int mi = 0;
            Random random = new Random();
            int max = -1000;
            int sum = 0;
            int maxsum = 0;
            int mj = 0;
            int obsum = 0;
            Console.WriteLine("Введите кол-во работников: ");
            int a = int.Parse(Console.ReadLine());
            int b = 3; //kvartal
            int[,] ar = new int[a,b];
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i+1 + " работник");
                for (int j = 0; j < b; j++)
                {

                    ar[i,j] = random.Next(0,100);
                    Console.WriteLine(j+1 + " квартал: " + ar[i,j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    sum = sum + ar[i, j]; // sum all
                    
                    if (ar[i,j] > max)
                    {
                        max = ar[i, j];
                    }
                    if (sum > obsum)
                    {
                        obsum = sum;
                    }
                    if (obsum > sum)
                    {
                        mj = j;
                    }
                }
               
                if (sum > maxsum)
                {
                    maxsum = sum;
                    mi = i+1;
                }
                sum = 0;
               
            }
            Console.WriteLine("максимальная зп в таблице: " + max);
            Console.WriteLine("Порядковый номер работника получившего за квартал наибольшую сумму: " + mi);
            Console.WriteLine("Общая максимальная зарплата была в " + mj + " квартале");
        }
    }
}
// в каком месяце общая зарплата всех работников была максимальной
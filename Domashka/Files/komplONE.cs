using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class komplONE
    {
        public void Go()
        {
            FileStream file = new FileStream("C:\\Dev\\FILES\\sumMG.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream file1 = new FileStream("C:\\Dev\\FILES\\sumMP.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            StreamWriter writer1 = new StreamWriter(file1);
            int n = 3;
            int[,] ar = new int[n,n];
            Random rnd = new Random();  
            int sumG = 0;
            int sumD = 0;
            // шаг 1 заполняю массив
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    ar[i, j] = rnd.Next(0, 10);
                    Console.Write(ar[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // шаг 2, ищу сумму главной или побочной диагонали;
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sumG+= ar[i, j];   // sum glav
                    }
                    if (i + j == n+1)
                    {
                        sumD+= ar[i, j]; // sum pob
                    }
                }
                Console.WriteLine();
            }
            // шаг 3, перед пользователем стоит выбор
            Console.WriteLine("Найти сумму: главной, или побочной?");
            string d = Console.ReadLine();
            if (d == "главной")
            {
                writer.WriteLine("сумма главной: " + sumG);
            }
            if (d == "побочной")
            {
                writer.WriteLine("сумма побочной: " + sumD);
            }
            writer.Close();
            writer1.Close();
        }
    }
}

//Вычислить сумму элементов главной или побочной диагонали
//квадратной матрицы в зависимости от выбора пользователя. Сумма
//элементов любой диагонали должна вычисляться в одном
//пользовательском методе. Программа создает два файла для хранения
//сумм элементов главной и побочной диагоналей. Предусмотрите
//корректность входных данных.
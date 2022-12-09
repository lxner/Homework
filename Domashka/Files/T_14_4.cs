using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_14_4
    {
       
        public void Go()
        {
            FileStream file=new FileStream("C:\\Dev\\FILES\\solution.txt",FileMode.OpenOrCreate,FileAccess.Write);StreamWriter writer=new StreamWriter(file);Console.WriteLine("Введите n: ");int n=int.Parse(Console.ReadLine());for(int i=0;i<n;i++){Console.WriteLine("Введите целое: ");byte a=byte.Parse(Console.ReadLine());writer.WriteLine(a);}writer.WriteLine();Console.WriteLine("Введите n: ");int nn=int.Parse(Console.ReadLine());for(int i=0;i<nn;i++){Console.WriteLine("Введите вещественное: ");float a=float.Parse(Console.ReadLine());writer.WriteLine(a);}writer.WriteLine();Console.WriteLine("Введите n: ");int nnn=int.Parse(Console.ReadLine());for(int i=0;i<nnn;i++){Console.WriteLine("Введите слово: ");string slovo=Console.ReadLine();writer.WriteLine(slovo);}writer.Close();
        }
       
    }
}
// создать файл и записать в него 
// 7 целых чисел
// 4 вещественных числа
// 5 слов




//static void celoe(int n, int i = 1)
//{
//    if (i <= n)
//    {
//        Console.WriteLine("Введите целое число: ");
//        int a = int.Parse(Console.ReadLine());
//        celoe(n, i+1);
//    }
//}
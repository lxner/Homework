using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class T_1_30B
    {
        public void Go()
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            double x =3.56*(a+b)*(a+b)*(a+b)-5.8*b*b+3.8*a-1.5;
            Console.Write("Итог: " + x);
        }
    }
}


//x =3.56*(a+b)*(a+b)*(a+b)-5.8*b*b+3.8*a-1.5
// при любых значениях a и b
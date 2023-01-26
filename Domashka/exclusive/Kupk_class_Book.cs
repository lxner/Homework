using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте класс Книга, обьявите в нем поле год выпуска, для доступа к этому полю реализуйте свойство. Год выпуска
//может быть в диапозоне от 1940 до 2022
namespace Domashka
{
    class Book
    {
        private int year_exit;

        public int Year_of_exit
        {
            get { return year_exit; }
            set 
            {
                year_exit = value;
                if (value < 1940)
                {
                    Console.WriteLine("год выпуска не может быть меньше 1940");
                    year_exit = 1940;
                }
                else if (value > 2022)
                {
                    Console.WriteLine("год выпуска не может быть больше 2022");
                    year_exit = 2022;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("год выпуска книги: " + Year_of_exit);
        }

    }

    internal class Kupk_class_Book
    {
        public void Go()
        {
            Book kniga1 = new Book();
            Console.WriteLine("enter: ");
            kniga1.Year_of_exit = int.Parse(Console.ReadLine());
            kniga1.Print();

        }
    }
}

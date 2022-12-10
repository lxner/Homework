using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class KomplTwo
    {
        public void Go()
        {
            var file = new FileStream("C:\\Dev\\FILES\\izdvd.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // двоич
            var file1 = new FileStream("C:\\Dev\\FILES\\izdvv.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);// восьм 
            var writer = new StreamWriter(file); // двоич
            var writer1 = new StreamWriter(file1); // восьм
            Console.WriteLine("Введите число: ");
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Перевести число: в двоичную? или в восьмеричную?");
            string convert = Console.ReadLine();
            if (convert == "в двоичную")
            {
                string dvoich = Convert.ToString(a, 2);
                writer.Write(a + " переводим в двоичную с.с: " + dvoich);
            }
            else
            {
                string vosm = Convert.ToString(a, 8);
                writer.Write(a + " переводим в восьмеричную с.с: " + vosm);
            }
            writer.Close();
            writer1.Close();
        }
    }
}
// использовал var только для практики, я помню что тебе это не нравится :)

// Написать программу, которая переводит число из десятичной системы
// счисления в двоичную или восьмеричную. Результаты записать в 2
// файла. Использовать пользовательские методы.
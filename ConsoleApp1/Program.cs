using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите номер пользователя:");
           int p1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Введите фамилию пользователя: ");
            string surname1 = Console.ReadLine();
            Console.Write("Введите имя пользователя: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите возраст пользователя: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сколько месяцев пользователю: ");
            int mec1 = Convert.ToInt32(Console.ReadLine());
            int agesec1 = 365 * age1 * 24 * 60 * 60 + mec1 * 30 * 60 * 60;
            Console.WriteLine();



            Console.Write("Введите номер пользователя:");
            int p2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите фамилию пользователя: ");
            string surname2 = Console.ReadLine();
            Console.Write("Введите имя пользователя: ");
            string name2 = Console.ReadLine();
            Console.Write("Введите возраст пользователя: ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сколько месяцев пользователю: ");
            int mec2 = Convert.ToInt32(Console.ReadLine());
            int agesec2 = 365 * age2 * 24 * 60 * 60 + mec2 * 30 * 60 * 60;
            Console.WriteLine();
            

            Console.Write("Введите номер пользователя:");
            int p3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите фамилию пользователя: ");
            string surname3 = Console.ReadLine();
            Console.Write("Введите имя пользователя: ");
            string name3 = Console.ReadLine();
            Console.Write("Введите возраст пользователя: ");
            int age3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сколько месяцев пользователю: ");
            int mec3 = Convert.ToInt32(Console.ReadLine());
            int agesec3 = 365 * age3 * 24 * 60 * 60 + mec3 * 30 * 60 * 60;
            Console.WriteLine();
           
            Console.WriteLine();
            Console.Write($"{surname1.PadRight(16)}{ name1.PadRight(16)} |Время в секундах:\t{agesec1}");
            Console.WriteLine();
            Console.Write($"{surname2.PadRight(16)}{name2.PadRight(16)} |Время в секундах:\t{agesec2}");
            Console.WriteLine();
            Console.Write($"{surname3.PadRight(16)}{name3.PadRight(16)} |Время в секундах:\t{agesec3}");




        }
    }
}

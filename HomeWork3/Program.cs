using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; // Изменяем цвет шрифта для печати в консоли на DarkGreen
            Base based = new Base(); // Создание базы данных
            based.Menu(); // Вывод меню
        }
    }
}

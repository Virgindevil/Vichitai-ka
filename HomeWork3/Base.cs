using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Base
    {
        public Base() // База данных
        {

        }                      

        public void Menu() // Вывод меню
        {

            int control = 0; // Присвоение значения переменной выбора по-умолчанию
            while (control != 4) // Условие НЕ равнения трём
            {               
                Console.SetCursorPosition(50, 3);
                Console.WriteLine($"ВЫЧИТАЙ-КА");
                Console.SetCursorPosition(50, 6);
                Console.WriteLine($"Сделайте выбор:");
                Console.SetCursorPosition(44, 8);
                Console.WriteLine($"1 - Режим для одного игрока");
                Console.SetCursorPosition(45, 10);
                Console.WriteLine($"2 - Режим для двух игроков");
                Console.SetCursorPosition(51, 12);
                Console.WriteLine($"3 - Правила");
                Console.SetCursorPosition(52, 14);
                Console.WriteLine($"4 - Выйти"); 
                Console.SetCursorPosition(57, 16);
                control = Convert.ToInt32(Console.ReadLine()); // Конвертирование вводимых данных
                if (!(control >= 1 && control <= 4))
                {
                    Console.SetCursorPosition(33, 18);
                    Console.WriteLine("Некорректный Ввод! Введите число от 1 до 4");
                    Console.SetCursorPosition(55, 20);
                    control = int.Parse(Console.ReadLine());
                }

                // Выриативность действий в зависимости от введённых данных
                switch (control)
                {
                    case 1: // Если ввели 1
                        Console.Clear();
                        Random random1 = new Random();
                        int choice1;
                        var names1 = new string[2];
                        Console.SetCursorPosition(49, 5);
                        Console.WriteLine("Введите имя игрока: ");
                        Console.SetCursorPosition(55, 7);
                        names1[0] = Console.ReadLine();                                             
                        names1[1] = ("Компьютер");

                        Console.SetCursorPosition(49, 10);
                        Console.WriteLine("Выберете сложность:");
                        Console.SetCursorPosition(42, 12);
                        Console.WriteLine("1 - Можно вводить числа от 1 до 4");
                        Console.SetCursorPosition(42, 13);
                        Console.WriteLine("2 - Можно вводить числа от 1 до 7");
                        Console.SetCursorPosition(42, 14);
                        Console.WriteLine("3 - Можно вводить числа от 1 до 10");
                        Console.SetCursorPosition(58, 16);
                        choice1 = int.Parse(Console.ReadLine());
                        int ii1 = random1.Next(12, 121), i1 = 0, playersinput1;
                        switch (choice1)
                        {
                            case 1:
                                for (; ii1 > 0; i1++)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(49, 5);
                                    Console.WriteLine("Ваше число: " + ii1);
                                    Console.SetCursorPosition(49, 7);
                                    Console.WriteLine("{0}, ваш ход", names1[0]);
                                    Console.SetCursorPosition(55, 9);
                                    playersinput1 = int.Parse(Console.ReadLine());
                                    i1 = 2;
                                    while (!(playersinput1 >= 1 && playersinput1 <= 4))
                                    {
                                        Console.SetCursorPosition(33, 11);
                                        Console.WriteLine("Некорректный ход! {0}, Введите число от 1 до 4", names1[0]);
                                        Console.SetCursorPosition(55, 13);
                                        playersinput1 = int.Parse(Console.ReadLine());
                                    }
                                    ii1 -= playersinput1;
                                    if (ii1 > 0)
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition(49, 5);
                                        Console.WriteLine("Ход компьютера!");
                                        Console.SetCursorPosition(38, 7);
                                        Console.WriteLine("Нажмите любую кнопку для перехода хода!");
                                        ii1 -= random1.Next(1, 5);
                                        i1 = 4;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    Console.ReadKey();
                                }
                                break;
                            case 2:
                                for (; ii1 > 0; i1++)
                                {
                                    Console.Clear();                                    
                                    Console.SetCursorPosition(49, 5);
                                    Console.WriteLine("Ваше число: " + ii1);
                                    Console.SetCursorPosition(49, 7);
                                    Console.WriteLine("{0}, ваш ход", names1[0]);
                                    Console.SetCursorPosition(55, 9);
                                    playersinput1 = int.Parse(Console.ReadLine());
                                    i1 = 2;
                                    while (!(playersinput1 >= 1 && playersinput1 <= 7))
                                    {
                                        Console.SetCursorPosition(33, 11);
                                        Console.WriteLine("Некорректный ход! {0}, Введите число от 1 до 7", names1[0]);
                                        Console.SetCursorPosition(55, 13);
                                        playersinput1 = int.Parse(Console.ReadLine());
                                    }
                                    ii1 -= playersinput1;
                                    if (ii1 > 0)
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition(49, 5);
                                        Console.WriteLine("Ход компьютера!");
                                        Console.SetCursorPosition(38, 7);
                                        Console.WriteLine("Нажмите любую кнопку для перехода хода!");
                                        ii1 -= random1.Next(1, 8);
                                        i1 = 4;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    Console.ReadKey();
                                }
                                break;
                            case 3:
                                for (; ii1 > 0; i1++)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(49, 5);
                                    Console.WriteLine("Ваше число: " + ii1);
                                    Console.SetCursorPosition(49, 7);
                                    Console.WriteLine("{0}, ваш ход", names1[0]);
                                    Console.SetCursorPosition(55, 9);
                                    playersinput1 = int.Parse(Console.ReadLine());
                                    i1 = 2;
                                    while (!(playersinput1 >= 1 && playersinput1 <= 10))
                                    {
                                        Console.SetCursorPosition(33, 11);
                                        Console.WriteLine("Некорректный ход! {0}, Введите число от 1 до 10", names1[0]);
                                        Console.SetCursorPosition(55, 13);
                                        playersinput1 = int.Parse(Console.ReadLine());
                                    }
                                    ii1 -= playersinput1;
                                    if (ii1 > 0)
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition(49, 5);
                                        Console.WriteLine("Ход компьютера!");
                                        Console.SetCursorPosition(38, 7);
                                        Console.WriteLine("Нажмите любую кнопку для перехода хода!");
                                        ii1 -= random1.Next(1, 11);
                                        i1 = 4;
                                    } 
                                    else   
                                    {
                                        break;
                                    }
                                    Console.ReadKey();
                                }
                                break;
                        }
                        Console.Clear();
                        Console.SetCursorPosition(48, 5);
                        Console.WriteLine("Число достигло нуля!");
                        Console.SetCursorPosition(52, 7);
                        Console.WriteLine("{0} победил!", names1[i1 % 2]);
                        Console.SetCursorPosition(38, 9);
                        Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2: // Если ввели 2
                        Console.Clear();
                        Random random = new Random();
                        int choice;                        
                        var names = new string[2];
                        Console.SetCursorPosition(46, 3);
                        Console.WriteLine("Введите имя первого игрока: ");
                        Console.SetCursorPosition(55, 4);
                        names[0] = Console.ReadLine();
                        Console.SetCursorPosition(46, 6);
                        Console.WriteLine("Введите имя второго игрока: ");
                        Console.SetCursorPosition(55, 7);
                        names[1] = Console.ReadLine();
                        
                        Console.SetCursorPosition(49, 10);
                        Console.WriteLine("Выберете сложность:");
                        Console.SetCursorPosition(42, 12);
                        Console.WriteLine("1 - Можно вводить числа от 1 до 4");
                        Console.SetCursorPosition(42, 13);
                        Console.WriteLine("2 - Можно вводить числа от 1 до 7");
                        Console.SetCursorPosition(42, 14);
                        Console.WriteLine("3 - Можно вводить числа от 1 до 10");
                        Console.SetCursorPosition(58, 16);
                        choice = int.Parse(Console.ReadLine());                        
                        int ii = random.Next(12, 121), i = 0, playersinput;
                        switch (choice)
                        {
                            case 1:
                                for (; ii > 0; i++)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(49, 5);
                                    Console.WriteLine("Ваше число: " + ii);
                                    Console.SetCursorPosition(49, 7);
                                    Console.WriteLine("{0}, ваш ход", names[i % 2]);
                                    Console.SetCursorPosition(55, 9);
                                    playersinput = int.Parse(Console.ReadLine());
                                    while (!(playersinput >= 1 && playersinput <= 4))
                                    {
                                        Console.SetCursorPosition(33, 11);
                                        Console.WriteLine("Некорректный ход! {0}, Введите число от 1 до 4", names[i % 2]);
                                        Console.SetCursorPosition(55, 13);
                                        playersinput = int.Parse(Console.ReadLine());
                                    }
                                    ii -= playersinput;
                                }
                                break;
                            case 2:
                                for (; ii > 0; i++)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(49, 5);
                                    Console.WriteLine("Ваше число: " + ii);
                                    Console.SetCursorPosition(49, 7);
                                    Console.WriteLine("{0}, ваш ход", names[i % 2]);
                                    Console.SetCursorPosition(55, 9);
                                    playersinput = int.Parse(Console.ReadLine());
                                    while (!(playersinput >= 1 && playersinput <= 7))
                                    {
                                        Console.SetCursorPosition(33, 11);
                                        Console.WriteLine("Некорректный ход! {0}, Введите число от 1 до 7", names[i % 2]);
                                        Console.SetCursorPosition(55, 13);
                                        playersinput = int.Parse(Console.ReadLine());
                                    }
                                    ii -= playersinput;
                                }
                                break;
                            case 3:
                                for (; ii > 0; i++)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(49, 5);
                                    Console.WriteLine("Ваше число: " + ii);
                                    Console.SetCursorPosition(49, 7);
                                    Console.WriteLine("{0}, ваш ход", names[i % 2]);
                                    Console.SetCursorPosition(55, 9);
                                    playersinput = int.Parse(Console.ReadLine());
                                    while (!(playersinput >= 1 && playersinput <= 10))
                                    {
                                        Console.SetCursorPosition(33, 11);
                                        Console.WriteLine("Некорректный ход! {0}, Введите число от 1 до 10", names[i % 2]);
                                        Console.SetCursorPosition(55, 13);
                                        playersinput = int.Parse(Console.ReadLine());
                                    }
                                    ii -= playersinput;
                                }
                                break;
                        }               
   
                        Console.Clear();
                        Console.SetCursorPosition(48, 5);
                        Console.WriteLine("Число достигло нуля!");
                        Console.SetCursorPosition(52, 7);
                        Console.WriteLine("{0} победил!", names[--i % 2]);
                        Console.SetCursorPosition(38, 9);
                        Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3: // Если ввели 3 - ПРАВИЛА
                        Console.Clear();
                        Console.SetCursorPosition(50, 3);
                        Console.WriteLine($"МЕГА-УГАДАЙ-КА");
                        Console.SetCursorPosition(53, 5);
                        Console.WriteLine($"ПРАВИЛА");
                        Console.SetCursorPosition(22, 7);
                        Console.WriteLine($"Игра загадывает случайное число от 12 до 120 сообщая это число игрокам.");
                        Console.SetCursorPosition(27, 9);
                        Console.WriteLine($"Игроки ходят по очереди(игра сообщает о ходе текущего игрока).");
                        Console.SetCursorPosition(18, 11);
                        Console.WriteLine($"Игрок, в свой ход, может вводить числа в том диапазоне, который выбран сложностью.");
                        Console.SetCursorPosition(27, 13);
                        Console.WriteLine($"Введёное игроком число отнимается из загаданного компьютером.");
                        Console.SetCursorPosition(21, 15);
                        Console.WriteLine($"Выигрывает тот игрок, после чьего хода загаданное число обратилась в ноль.");
                        Console.SetCursorPosition(45, 17);
                        Console.WriteLine($"В ИГРЕ ЕСТЬ ДВА РЕЖИМА:");
                        Console.SetCursorPosition(37, 19);
                        Console.WriteLine($"Режим одного игрока, против компьютера.");
                        Console.SetCursorPosition(37, 21);
                        Console.WriteLine($"Режим двоих игроков, против друг друга.");
                        Console.SetCursorPosition(37, 26);
                        Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4: // Если ввели 4 - ВЫХОД
                        Environment.Exit(0); // Выход
                        break;
                    default:
                        break;
                }
            }
        }
    }
}


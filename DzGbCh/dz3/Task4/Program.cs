// Это сборная программа из четырех программ, с решением трех задач +плюс одна на общее решение двух из них
// бОльшая часть кода - это ненужная мишура, которая здесь либо для того, чтобы нельзя было ввести не ту цифру, либо для повтора программы
// либо еще для какой-то "красоты"...
Console.Clear();
Thread.Sleep(500);  // спать в мс

foreach (char letter in "AntonkinAnton Production...")  //для каждого символа в строке, делать...
{
    Console.Write(letter);
    Thread.Sleep(40);
}
Thread.Sleep(1200);
Console.Clear();
foreach (char letter in "Представляет...")
{
    Console.Write(letter);
    Thread.Sleep(40);
}
Thread.Sleep(1000);
Console.Clear();
foreach (char letter in "Здравствуйте!!")
{
    Console.Write(letter);
    Thread.Sleep(40);
}
Console.WriteLine();
Console.WriteLine();
Thread.Sleep(150);
foreach (char letter in "Представляю Вам программу, включающую в себя решение четырех задач на выбор....")
{
    Console.Write(letter);
    Thread.Sleep(25);
}
Thread.Sleep(1000);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press Enter....");
Console.ReadLine();
Console.Clear();
Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Сделайте Ваш выбор:");  //choose your destiny...
Console.ResetColor();
int task;
bool globalexit = false;
do
{
    do
    {

        Console.Clear();
        Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Сделайте Ваш выбор:");  //choose your destiny...
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Задача 1 - про трёхзначное число и вторую цифру этого числа на выходе");
        Console.WriteLine("Задача 2 - про третью цифру заданного числа или про её отсутствие");
        Console.WriteLine("Задача 3 - про любую цифру любого числа, либо про удаление любого кол-ва цифр из числа*");  // Задача не из дз
        Console.WriteLine("Задача 4 - про дни недели и выходные");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Введите номер задачи 1-4");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Выход - 0");
        Console.ResetColor();
        Console.WriteLine();
    } while (!int.TryParse(Console.ReadLine(), out task) || task < 0 || task > 4);

    switch (task)
    {
        case 1:
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
                Console.WriteLine();
                Console.WriteLine("Программа показывает вторую цифру из трехзначного числа");
                Console.WriteLine();
                Console.WriteLine("Введите трёхзначное число: ");
                // <-------------------------------Отсюда начинается основной код программы 1---------------------------------->
                int num1;
                while (!int.TryParse(Console.ReadLine(), out num1) || num1 < 99 && num1 > -100 || num1 > 1000) // Программа принимает и отрицательные числа
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("WRONG!!!");
                    Console.Beep();                    // Если введено не число, либо не трехзначное число, то прозвучит сигнал
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Введите трёхзначное число: "); //Будет предлагать ввести, пока не введешь трехзначное
                }
                Console.WriteLine();
                Console.WriteLine($"Вторая цифра числа {num1}: {Math.Abs(num1 = num1 / 10 % 10)}"); //берет модуль числа, удаляет последнюю цифру путем деления и окр, и первую, путем вывода остатка
                Console.WriteLine();
                // <-------------------------Здесь заканчивается основной код программы 1--------------------------------->
                while (exit == false)
                {
                    Console.WriteLine("Повторим? (Y/N)");
                    ConsoleKeyInfo Key = Console.ReadKey(); // кладем в переменную нажатую клавишу
                    Console.WriteLine();
                    if (Key.Key == ConsoleKey.Y)
                    {
                        exit = false;
                        break;
                    }
                    else if (Key.Key == ConsoleKey.N)
                    {
                        exit = true;
                        break;
                    }
                }

            } while (exit == false);
            break;

        case 2:
            //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

            long num;  // лонг для использование бОльших чисел
            do
            {
                Console.Clear();
                Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
                Console.WriteLine();
                Console.WriteLine("Программа показывает третью цифру числа от –9223372036854775808 до 9223372036854775807");
                Console.WriteLine();
                Console.WriteLine("Введите число:");
                Console.WriteLine();

            }
            while (!long.TryParse(Console.ReadLine(), out num));

            long primal = num;  // переменная для вывода на печать первоначального числа в конце программы
            if (num < 99 && num > -100)  // если введенное число имеет два или один символ
            {
                Console.WriteLine();
                Console.WriteLine("Третьей цифры нет (° ͜ʖ ͡°)_/¯");
                Environment.Exit(0);
            }

            while (num > 999 || num < -999)   //если число не трехзначное - убираем последний знак до тех пор, пока не станет трехзначным
            {
                num /= 10;
            }
            Console.WriteLine();
            Console.WriteLine($"Третья цифра числа {primal}: {Math.Abs(num % 10)}");   // убираем два первых знака трехзначного числа
            Console.WriteLine();
            Console.WriteLine("Мне надоело делать повторный запуск программы, поэтому ВЫХОД!");
            Console.WriteLine("Press Enter...");
            Console.ReadKey();

            break;

        case 3:
            //Программа выводит любую заданную цифру любого введенного числа, либо удаляет любое кол-во цифр из числа
            long input;
            int pos;
            int del;
            bool exit1 = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
                Console.WriteLine();
                Console.WriteLine("Программа выводит любую цифру заданного порядкового номера любого введенного числа,");
                Console.WriteLine("либо удаляет заданное количество цифр с заданного порядкового номера числа");
                Console.WriteLine();
                Console.WriteLine("Введите число:");

            } while (!long.TryParse(Console.ReadLine(), out input));

            string conv = Convert.ToString(input);  // конвертируем инт в стр, чтобы потом удалять символы. Сразу не делаем стр, чтобы ввод был только числа
            int len = conv.Length;

            Console.WriteLine("Что вы хотите сделать с числом?");
            Console.WriteLine();
            Console.WriteLine("1 - вывести цифру по порядковому номеру");
            Console.WriteLine("2 - удалить цифры с порядкового номера");
            Console.WriteLine();

            int choose;
            while (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 2) // оставляем ввод только 1 и 2
            {
                Console.Beep();                                   // сигнал
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("WRONG!!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine($"Что вы хотите сделать с числом {conv}?");
                Console.WriteLine();
                Console.WriteLine("1 - вывести цифру по порядковому номеру");
                Console.WriteLine("2 - удалить цифры с порядкового номера");
                Console.WriteLine();
            }
            switch (choose)    //делаем выбор программы
            {
                case 1:
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Введите порядковый номер цифры от 1 до {len}");
                    } while (!int.TryParse(Console.ReadLine(), out pos) || pos <= 0 || pos > len);  //получаем порядковые номера длинны числа

                    conv = conv.Remove(pos, (len - pos));
                    conv = conv.Remove(0, pos - 1);       // удаляем все цифры, кроме выбранной
                    Console.WriteLine();
                    Console.WriteLine($"{pos}-я цифра числа {input} -- {conv}");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter...");
                    Console.ReadKey();
                    break;
                case 2:
                    while (exit1 == false)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Введите порядковый номер цифры от 1 до {len}");

                        } while (!int.TryParse(Console.ReadLine(), out pos) || pos <= 0 || pos > len);


                        do
                        {
                            Console.WriteLine($"Введите количество удаляемых цифр от 1 до {len - pos + 1}");
                        } while (!int.TryParse(Console.ReadLine(), out del) || del <= 0 || del > len - pos + 1);

                        conv = conv.Remove(pos - 1, del);
                        Console.WriteLine($"Итоговое число: {conv}");
                        if (conv == "") break;
                        Console.WriteLine();
                        Console.WriteLine("Продолжим удалять цифры? (Y/N)");
                        len = conv.Length;
                        ConsoleKeyInfo Key = Console.ReadKey(); // кладем в переменную нажатую клавишу
                        Console.WriteLine();


                        if (Key.Key == ConsoleKey.Y)
                        {
                            exit1 = false;
                            Console.WriteLine($"Число: {conv}");


                        }
                        else if (Key.Key == ConsoleKey.N)
                        {
                            exit1 = true;
                            break;

                        }
                        else break;




                    }
                    break;
            }


            break;

        case 4:

            //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

            void Days(int arg)
            {
                if (arg == 1) Console.WriteLine("Это Понедельник, максимально не выходной! :-< ");
                else if (arg == 2) Console.WriteLine("Это Вторник, не выходной! :-/ ");
                else if (arg == 3) Console.WriteLine("Это Среда, наполовину недели не выходной! :-| ");
                else if (arg == 4) Console.WriteLine("Это Четверг, немного не выходной! (・・ ) ");
                else if (arg == 5) Console.WriteLine("Это Пятница, до вечера не выходной! (¬ ¬ ) ");
                else if (arg == 6) Console.WriteLine("Это Суббота, СУПЕРВЫХОДНОЙ! :-() ");
                else if (arg == 7) Console.WriteLine("Это Воскресенье, выходной, но завтра...../:-] ");




            }
            int daynum;
            Console.Clear();
            Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
            Console.WriteLine();
            Console.WriteLine("Программа выводит день недели заданного числа от 1 до 7, и показывает выходной это или нет");
            Console.WriteLine();
            Console.WriteLine("Введите цифру от 1 до 7:");

            while (!int.TryParse(Console.ReadLine(), out daynum) || daynum < 1 || daynum > 7)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Я СКАЗАЛ ЧИСЛО ОТ 1 ДО 7!!! Это так сложно??");
                Console.ResetColor();
                Console.WriteLine("Введите цифру от 1 до 7:");
                Console.WriteLine();
            }
            Console.WriteLine();
            Days(daynum);

            Console.WriteLine();
            Console.Write("А сегодня, кстати, ");
            Console.WriteLine(DateTime.Today.ToString("dddd"));  // получает сегодняшнюю дату и оставляет только день недели
            Console.WriteLine();
            Console.WriteLine("Press Enter...");
            Console.ReadKey();

            break;

        case 0:
            globalexit = true;
            break;

    }

} while (globalexit == false);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("До скорой встречи!");
Console.ResetColor();
Console.ReadKey();
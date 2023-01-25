//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Используем % 2, проверяем, больше ли нуля остаток (не равен нулю)

int x;
do
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
    Console.WriteLine();
    Console.WriteLine("Программа показывает, является ли число четным");
    Console.WriteLine();
    Console.WriteLine("Введите число:");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    if (int.TryParse(Console.ReadLine(), out x))
    {
    Console.ResetColor();
    Console.Write("Число ");

    Console.WriteLine(x % 2 == 0 ? "четное " : "нечетное");
    
    Console.WriteLine();
    Console.WriteLine("Повторим?");
    Console.WriteLine("Enter - Да / AnyKey - Выход");
    }
    else 
    {
        Console.ResetColor();
        Console.WriteLine("Вы ввели не число!");
        Console.WriteLine();
        Console.WriteLine("Попробуете еще раз?");
        Console.WriteLine("Enter - Да / AnyKey - Выход");
    }
}
while (Console.ReadKey().Key == ConsoleKey.Enter);
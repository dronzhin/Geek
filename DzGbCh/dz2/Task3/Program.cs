// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string userStrNumber = "a";
int userIntNumber;
bool exit = false;
int flag = 0;
while (exit == false)
{
    while (int.TryParse(userStrNumber, out userIntNumber) != true || int.Parse(userStrNumber) > 7)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Введите число дня недели от 1 до 7:");
            userStrNumber = Console.ReadLine();
        }
    string [] dayWeek = {"Понедельние", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    System.Console.WriteLine();
    System.Console.WriteLine($"Вы точно ввели день недели - {dayWeek[userIntNumber-1]} ?");
    System.Console.WriteLine("Если Да то введите Y");
    System.Console.WriteLine("Если Нет то введите N и введите заново");
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() == "y")
    {
        string [] dayWeekend = {"Суббота", "Воскресенье"};
        int len = dayWeekend.Length;
        for (int i = 0; i < len; i++)
        {
            if (dayWeek[userIntNumber-1] == dayWeekend[i]) 
            {
            flag = 1;
            }
        }
        if (flag == 1)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"День недели {dayWeek[userIntNumber-1]} - Выходной");
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"День недели {dayWeek[userIntNumber-1]} - Будний день");
            System.Console.WriteLine();
        }
        exit = true;
    }
    else
    {
        userStrNumber = "Not";
    }
}
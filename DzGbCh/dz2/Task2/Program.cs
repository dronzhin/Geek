// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
string userStrNumber = "a";
int userIntNumber;
bool exit = false;
do
{
    while (int.TryParse(userStrNumber, out userIntNumber) != true)
    {
        System.Console.WriteLine("Введите число:");
        userStrNumber = Console.ReadLine();
    }
    if (userStrNumber.Length <= 2)
    {
        System.Console.WriteLine("В вашем числе третьей цифры нет");
        exit = true;
    }
    else
    {
    System.Console.WriteLine("Первый способ решение задачи - вытаскивание третьего строчного символа");
    System.Console.WriteLine(userStrNumber[2].ToString());
    System.Console.WriteLine("Второй способ решение задачи - остаток от деления");
    int numberCount = Convert.ToInt32(Math.Pow(10, userStrNumber.Length - 3));
    System.Console.WriteLine(userIntNumber/numberCount%10);
    }
}
while (exit = false);
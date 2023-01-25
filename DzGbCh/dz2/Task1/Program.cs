// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1
string userStrNumber = "11";
int userIntNumber;
while (userStrNumber.Length <= 2 || userStrNumber.Length > 3 || int.TryParse(userStrNumber, out userIntNumber) != true)
{
    System.Console.WriteLine("Введите трехзначное число:");
    userStrNumber = Console.ReadLine();
}
System.Console.WriteLine("Первый способ решение задачи - вытаскивание второго строчного символа");
System.Console.WriteLine(userStrNumber[1].ToString());
System.Console.WriteLine("Второй способ решение задачи - остаток от деления");
System.Console.WriteLine(userIntNumber/10%10);
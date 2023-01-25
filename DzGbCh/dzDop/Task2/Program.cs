// 2)Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
bool exit = false;
int len;
while (exit == false)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Введите число :");
    string number = Console.ReadLine();
    int intNumber;
    if (int.TryParse(number, out intNumber) == true)
    {
        len = number.Length;
        System.Console.WriteLine($"Число {number} состоит из {len} цифр");
        System.Console.WriteLine();
        exit = true;
    }
    else
    {
        System.Console.WriteLine("Введено было не число");
    }
}
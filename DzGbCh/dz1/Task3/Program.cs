System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result = number % 2;
if (result == 0)
{
    System.Console.WriteLine($"Введенное число {number} является чётным");
}
else
{
    System.Console.WriteLine($"Введенное число {number} является нечётным");
}
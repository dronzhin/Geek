int number1 = new Random().Next(1, 100);
int number2 = new Random().Next(1, 100);
Console.WriteLine($"Введено число {number1} и число {number2}");
if (number1 > number2)
{
    System.Console.WriteLine($"Число {number1} больше числа {number2}");
}
if (number1 < number2)
{
    System.Console.WriteLine($"Число {number2} больше числа {number1}");
}
else
{
    System.Console.WriteLine($"Число {number2} равно числу {number1}");
}

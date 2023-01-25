System.Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
System.Console.WriteLine($"Вы ввели числа {number1}, {number2}, {number3}");
System.Console.WriteLine($"Наибольшее число из них {max}");
string number = "5";
while (number.Length <= 2 ^ int.TryParse(number, out var i) != true)
{   
    System.Console.WriteLine("Введите число большее 99");
    number = Console.ReadLine();
}
char num = number[1];
System.Console.WriteLine($"Второе число равно - {num}");
num = number[2];
System.Console.WriteLine($"Третье число равно - {num}");
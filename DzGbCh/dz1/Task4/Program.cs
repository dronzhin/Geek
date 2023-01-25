System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i++)
{
    if (i%2 == 0) Console.Write(i + " ");
} 

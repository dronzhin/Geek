// 3)Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120
bool exit = false;
int sumNumber(int num)
{
    if (num == 1) return 1;
    return num * sumNumber(num - 1);

}
while (exit == false)
{
    try
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Введите число :");
        int number = int.Parse(Console.ReadLine());
        
        int sum = sumNumber(number);
        System.Console.WriteLine();
        System.Console.WriteLine("1 способ - рекурсивная функция");
        System.Console.WriteLine($"Сумма произведение чисел от 1 до {number} равна - {sum}");
        
        int sumNew = 1;
        for (int i = 1; i <= number; i++)
        {
            sumNew = sumNew*i;
        }
        System.Console.WriteLine();
        System.Console.WriteLine("2 способ - через цикл");
        System.Console.WriteLine($"Сумма произведение чисел от 1 до {number} равна - {sumNew}");
        System.Console.WriteLine();
        exit = true;

    }
    catch 
    {
        System.Console.WriteLine("Введено было не число");
    }
}
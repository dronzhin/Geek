// 1)Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
bool exit = false;
int sumNumber(int num)
{
    if (num == 1) return 1;
    return num + sumNumber(num - 1);

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
        System.Console.WriteLine($"Сумма чисел от 1 до {number} равна - {sum}");
        
        int sumNew = 0;
        for (int i = 1; i <= number; i++)
        {
            sumNew += i;
        }
        System.Console.WriteLine();
        System.Console.WriteLine("2 способ - через цикл");
        System.Console.WriteLine($"Сумма чисел от 1 до {number} равна - {sumNew}");
        System.Console.WriteLine();
        exit = true;

    }
    catch 
    {
        System.Console.WriteLine("Введено было не число");
    }
}
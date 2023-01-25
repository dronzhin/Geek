//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//ждем ввод двух чисел, сверяем одно с другим, выводим макс.
int num1;
int num2;
bool exit = false;
do
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
    Console.WriteLine();
    Console.WriteLine("Программа показывает большее из двух чисел");
    Console.WriteLine();

    try
    {
        Console.WriteLine("Введите первое число:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Введите второе число:");
        num2 = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Вы втираете какую-то дичь. Прощайте!");
        Console.ReadKey();
        return;
    }
    Console.WriteLine();
    if (num1 > num2)
    {
        Console.WriteLine("Число {0} больше", num1);
    }
    else if (num1 == num2)
    {
        Console.WriteLine("Числа равны!");
    }
    else
    {
        Console.WriteLine("Число {0} больше", num2);
    }
    bool agree = false;
    do
    {
        Console.WriteLine();
        Console.WriteLine("Еще разок? (Y/N)");
        string again = Console.ReadLine();
        if (again.ToLower() == "y")
        {
            exit = false;
            agree = true;
        }
        else if (again.ToLower() == "n")
        {
            exit = true;
            agree = true;
        }
    }
    while (agree == false);

    Console.WriteLine();
} while (exit == false);

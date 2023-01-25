// В первой и единственной строке входных данных записано целое число w (1 ≤ w ≤ 100) — вес купленного ребятами арбуза 10 кг арбуз
// ВЫВОД
// 2 8
// 4,6
// 6,4
// 8,2
bool exit = false;
while (exit == false)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Введите число от 1 до 100 :");
    string number = Console.ReadLine();
    int intNumber;
    if (int.TryParse(number, out intNumber) == true && intNumber > 0 && intNumber < 101)
    {
        if (intNumber < 4 || intNumber%2 == 1) 
        {
        System.Console.WriteLine("Нет правильного ответа");
        exit = true;
        }
        else
        {
            for (int i = 2; i < intNumber; i += 2)
            {
                System.Console.WriteLine($"{i.ToString()} - {(intNumber - i).ToString()}");
            }
        exit = true;
        }
    }
   else
    {
        System.Console.WriteLine("Введено было не число от 1 до 100");
    }
}
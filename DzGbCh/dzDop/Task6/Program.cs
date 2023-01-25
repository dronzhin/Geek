// Дан массив размера N. Найти номер его первого локального минимума (локальный минимум - это элемент, который меньше любого из своих соседей)
bool exit = false;

while (exit == false)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Введите количество элеменотов массива :");
    string number = Console.ReadLine();
    int intNumber;
    int numberIndex =0;
    if (int.TryParse(number, out intNumber) == true)
    {
        int [] array = new int[intNumber];
        for (int i = 0; i < intNumber; i++)
        {
            array[i] = new Random().Next(0,100);
        }
        Console.WriteLine("[" + string.Join(", ", array) + "]");
        for (int j = 1; j < (intNumber-1); j++)
        {
            if (array[j] < array[j-1] && (array[j] < array[j+1]))
            {
                numberIndex = j;
                System.Console.WriteLine($"Локальный минимум находится под индексом - {numberIndex}");
                break;
            }
           if (numberIndex == 0) System.Console.WriteLine("Локального минимума нет в текущем массиве");
        }
        exit = true;
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}
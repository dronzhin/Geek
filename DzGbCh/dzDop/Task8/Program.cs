// Дан массив N, найти максимальный из его локальных минимумов
bool exit = false;

while (exit == false)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Введите количество элеменотов массива :");
    string number = Console.ReadLine();
    int intNumber;
    int numberIndex =0;
    int localMin = -1;
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
            if (array[j] < array[j-1] && (array[j] < array[j+1]) && array[j] > localMin)
            {
                localMin = array[j];    
            }
        }
        if (localMin != -1)
        {
            System.Console.WriteLine($"Максимальный локальный минимум равен - {localMin}");
        }
        else
        {
            System.Console.WriteLine("Нет локальных минимумов");
        }
        exit = true;
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}
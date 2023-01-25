// Дан массив размера N. Найти количество участков и вывести их, на которых его элементы монотонно возрастают
bool exit = false;
string str1 = "";
int count = 0;
while (exit == false)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Введите количество элеменотов массива :");
    string number = Console.ReadLine();
    int intNumber;
    if (int.TryParse(number, out intNumber) == true)
    {
        int [] array = new int[intNumber];
        for (int i = 0; i < intNumber; i++)
        {
            array[i] = new Random().Next(0,100);
        }
        Console.WriteLine("[" + string.Join(", ", array) + "]");
        if (array[0] < array[1]) str1 = array[0].ToString() + "-";
        for (int j = 1; j < (intNumber-1); j++)
        {
            if (array[j] < array[j+1])
            {
                str1 = str1 + array[j].ToString() + "-";
            }
            else
            {
                if(array[j] > array[j-1]) 
                    {
                    str1 = str1 + array[j].ToString() + "   ";
                    count++;
                    }
            }
        }
        if (array[intNumber-2] < array[intNumber-1]) str1 = str1 + array[intNumber-1].ToString();
        if (array[intNumber-2] < array[intNumber-1]) count++;
        System.Console.WriteLine();
        System.Console.WriteLine(str1);
        System.Console.WriteLine($"Количество участков на которых, его элементы монотонно возрастают - {count}");
        System.Console.WriteLine();
        exit = true;
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}
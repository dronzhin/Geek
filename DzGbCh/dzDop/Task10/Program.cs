// Дан массив размера N. Найти два соседних элемента, сумма которых максимальна, и вывести эти элементы в порядке возрастания их индексов
bool exit = false;
int max = 0;
string strNumner = "";
string indexNumber = "";
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
        for (int j = 1; j < intNumber-1; j++)
        {
            if (max < (array[j-1] + array[j+1]))
            {
                max = array[j-1] + array[j+1];
                strNumner = array[j-1].ToString() + ", " + array[j].ToString() + ", "+ array[j+1].ToString();
                indexNumber = (j-1).ToString()+ ", " + j.ToString() + ", " + (j+1).ToString();
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Максимальная сумма двух ближайщих элементов равна {max}");
        System.Console.WriteLine($"Элементы попорядку - {strNumner}");
        System.Console.WriteLine($"Индексы элементов попорядку - {indexNumber}");
        exit = true;
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}
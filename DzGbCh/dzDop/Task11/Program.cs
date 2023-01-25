// Дан массив размера N. Найти номера двух ближайших элементов из этого массива (элементов с наименьшим модулем разности) и вывести эти номера в порядке возрастания
bool exit = false;
int min = 100;
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
            if (min > Math.Abs(array[j-1] - array[j+1]))
            {
                min = Math.Abs(array[j-1] - array[j+1]);
                strNumner = $"|{array[j-1].ToString()} - {array[j+1].ToString()}| = {min.ToString()}";
                indexNumber = (j-1).ToString()+ ", " + j.ToString() + ", " + (j+1).ToString();
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Наименьший модуль разности {strNumner}");
        System.Console.WriteLine($"Индексы элементов попорядку - {indexNumber}");
        exit = true;
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}
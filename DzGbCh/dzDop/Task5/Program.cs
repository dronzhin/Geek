// 5) Заполнить массив случайными числами (количество элементов с клавиатуры)
bool exit = false;

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
        exit = true;
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}
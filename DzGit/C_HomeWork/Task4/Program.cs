//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//mod: Занести значения в List, сделать переключатель случайных неповторяющихся цветов.
//получаем число N, начинаем перебор четных от 1 с внесением в List, с отсечкой по N

void Setcolor(int clr)

{
    if (clr == 1) Console.ForegroundColor = ConsoleColor.Blue;
    else if (clr == 2) Console.ForegroundColor = ConsoleColor.Cyan;
    else if (clr == 3) Console.ForegroundColor = ConsoleColor.DarkBlue;
    else if (clr == 4) Console.ForegroundColor = ConsoleColor.DarkCyan;
    else if (clr == 5) Console.ForegroundColor = ConsoleColor.DarkGray;
    else if (clr == 6) Console.ForegroundColor = ConsoleColor.DarkGreen;
    else if (clr == 7) Console.ForegroundColor = ConsoleColor.DarkMagenta;
    else if (clr == 8) Console.ForegroundColor = ConsoleColor.DarkRed;
    else if (clr == 9) Console.ForegroundColor = ConsoleColor.DarkYellow;
    else if (clr == 10) Console.ForegroundColor = ConsoleColor.Gray;
    else if (clr == 11) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 12) Console.ForegroundColor = ConsoleColor.Magenta;
    else if (clr == 13) Console.ForegroundColor = ConsoleColor.Red;
    else if (clr == 14) Console.ForegroundColor = ConsoleColor.White;
    else if (clr == 15) Console.ForegroundColor = ConsoleColor.Yellow;
}
bool agree = false;
int N;

do
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains");
    Console.WriteLine();
    Console.WriteLine("Программа показывает все четные числа от 1 до введенного числа");
    Console.WriteLine();
    Console.WriteLine("Введите число:");
    Console.WriteLine();

    if (int.TryParse(Console.ReadLine(), out N))
    {
        Console.WriteLine();
        Console.WriteLine("Все четные числа до {0}:", N);
        int count = 1;
        List<int> Numbers = new List<int>();
        while (count <= N)
        {
            if (count % 2 == 0)
            {
                Numbers.Add(count);
            }
            count++;
        }
        count = 0;
        int Lenght = Numbers.Count;
        int repclr = 0;
        int clr = new Random().Next(1, 16);
        while (count <= Lenght - 1)
        {

            while (repclr == clr)
            {
                clr = new Random().Next(1, 16);
            }
            Setcolor(clr);
            Console.Write(Numbers[count]);
            if (count == Lenght - 1)
            {
                break;
            }
            else
            {
                Console.ResetColor();
                Console.Write(":");
            }
            repclr = clr;
            count++;

        }
        Console.ResetColor();
        Console.WriteLine();
        do
        {
            Console.WriteLine();
            Console.WriteLine("Заново? (Да/Нет)");
            string again = Console.ReadLine();
            if (again.ToLower() == "нет")
            {
                agree = false;
                break;
            }
            else if (again.ToLower() == "да")
                agree = true;
        } while (agree == false);
    }
    else agree = true;
} while (agree == true);
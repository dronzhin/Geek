// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 12321 - да
// 34214 - нет
// 45654 - да
bool exit = false;
int length;
while (exit == false)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Введите число для проверки :");
    string number = Console.ReadLine();
    length = number.Length;
    int intNumber;
    int flag = 1;
    if (int.TryParse(number, out intNumber))
    {
        char [] sym = number.ToCharArray();
        for (int i = 0; i < length/2; i++)
        {
            if (sym[i]==sym[length-1-i])
            {
                flag *=1;
            }
            else
            {
                flag *=-1;
            }
        }
        if (flag == 1)
        {
            System.Console.WriteLine($"Число {number} - палиндром");
        }
        else
        {
            System.Console.WriteLine($"Число {number} - не палиндром");
        }
        exit = true;
        
    }
   else
    {
        System.Console.WriteLine("Введено было не число");
    }
}
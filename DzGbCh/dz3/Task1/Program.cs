// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 12321 - да
// 34214 - нет
// 45654 - да

string GetStringUserNumber(string request)
{
    System.Console.WriteLine();
    System.Console.Write(request);
    return Console.ReadLine();  
}
bool CheckPalindrone(String number)
{
    int length = number.Length;
    int flag = 1;
    char [] sym = number.ToCharArray();
    for (int i = 0; i < length/2; i++)
    {
        flag = (sym[i]==sym[length-1-i]) ? flag*1 : flag*0;
    }
    bool check = (flag == 1) ? true : false;
    return check;
}
 
string userNumber = GetStringUserNumber("Введите число - ");
if (CheckPalindrone(userNumber))
{
    System.Console.WriteLine($"Число {userNumber} - палиндром");
}
else
{
    System.Console.WriteLine($"Число {userNumber} - не палиндром");
}
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using System;
{
    
}
int GetIntUserNumber(string request)
{
    System.Console.Write(request);
    return int.Parse(Console.ReadLine());
}
string GetTableDegree(int Number, int Degree)
{
    string str = string.Empty;
    for (int i = 1; i <= Number; i++)
    {
        str += (Convert.ToInt32(Math.Pow(i, Degree))).ToString() + " ";
    }
    return str;
}

int Number = GetIntUserNumber("Введите число - ");
int Degree = GetIntUserNumber("Введите степень - ");
string answer = GetTableDegree(Number, Degree);
System.Console.WriteLine(answer);

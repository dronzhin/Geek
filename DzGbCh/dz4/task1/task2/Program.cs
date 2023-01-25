using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

namespace task2
{
    internal class Program
    {
        static int enterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int summAllNumberInValue(int value)
        {
            int result = 0;
            for (int i = 0; value > 0; i++)
            {
                result += value % 10;
                value /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number = enterValue("Введите число");
            Console.WriteLine($"Сумма всех цифр в значении {number} равна {summAllNumberInValue(number)}");
            Console.ReadKey();
        }
    }
}

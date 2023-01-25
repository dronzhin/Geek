using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16

namespace task1
{
    internal class Program
    {
        static int enterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int exponentiation(int value, int degree)
        {
            int result = 1;
            for (int i = 0; i < degree; i++)
                result *= value;
            return result;
        }
        static void Main(string[] args)
        {
            int number = enterValue("Введите число");
            int degree = enterValue("Введите степень");
            Console.WriteLine($"Число {number} возведенное в {degree} степень равен {exponentiation(number, degree)}");
            Console.ReadKey();
        }
    }
}

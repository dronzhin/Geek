using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5-> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

namespace dopTask6
{
    internal class Program
    {
        static int enterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static string fibanachiA(int value)
        {
            int fiboLast = 1;
            int fiboPenultimate = 0;
            int rememberValue = 0;
            string result = "0 1";
            for (int i = 2; i < value; i++)
            {
                rememberValue = fiboLast;
                fiboLast += fiboPenultimate;
                fiboPenultimate = rememberValue;
                result += " " + fiboLast;
            }
            return result;
        }
        static string fibanachiB(int value)
        {
            int[] array = { 0, 1 };
            for (int i = 2; i < value; i++)
            {
                Array.Resize(ref array, i+1); 
                array[i] = array[i-2] + array[i - 1];
            }
               
            return string.Join(" ", array);
        }
        static void Main(string[] args)
        {
            int number = enterValue("Введите число");
            Console.WriteLine(fibanachiA(number));
            Console.WriteLine(fibanachiB(number));
            Console.ReadKey();
        }
    }
}

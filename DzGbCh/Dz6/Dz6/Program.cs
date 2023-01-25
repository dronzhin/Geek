using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

namespace Task1
{
    internal class Program
    {
        static int[] EnterValueArray()
        {
            string str = string.Empty;
            int count = 0;
            int[] array = new int[100];
            string strArray = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Введите число, если закончили вводить числа, то наберите  - Нет : ");
                str = Console.ReadLine();
                if (str.ToLower() == "нет")
                {
                    Array.Resize(ref array, count);
                    return array;
                }
                else if (!int.TryParse(str, out int result))
                {
                    Console.WriteLine("Введите число или нет");
                }
                else
                {
                    array[i] = int.Parse(str);
                    strArray += array[i] + ", ";
                    Console.WriteLine(strArray);
                    count++;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = EnterValueArray();
            int length = array.Length;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                count = (array[i] > 0) ? count = count + 1 : count;
            }
            Console.WriteLine();
            Console.WriteLine($"Были введены числа {string.Join(", ", array)} - {count} из них больше нуля");
            Console.ReadKey();

        }
    }
}

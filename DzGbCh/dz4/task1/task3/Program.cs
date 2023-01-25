using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

namespace task3
{
    internal class Program
    {
        static int enterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int [] createRandomArray(int lengthArray, int minValue = 0, int maxValue = 100)
        {
            var array = new int[lengthArray];
            Random random = new Random();
            for (int i = 0; i < lengthArray; i++)
                array[i] = random.Next(minValue, maxValue);
            return array;
        }
        static void printArray(int[] array)
        {
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
        static void Main(string[] args)
        {
            int lengthArray = enterValue("Введите длину массива");
            int minArray = enterValue("Введите минимальное значение массива");
            int maxArray = enterValue("Введите максимальное значение массива");

            var array = createRandomArray(lengthArray, minArray, maxArray);
            printArray(array);
            Console.ReadKey();
        }
    }
}

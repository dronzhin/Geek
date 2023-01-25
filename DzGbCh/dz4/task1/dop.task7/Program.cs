using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

namespace dop.task7
{
    internal class Program
    {
        static int enterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] createRandomArray(int lengthArray, int minValue = 0, int maxValue = 100)
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
        static int[] copyArray(int[] array)
        {
            int length = array.Length;
            var newArray = new int[length];
            for (int i = 0; i < length; i++)
                newArray[i] = array[i];
            return newArray;
        }
        static void Main(string[] args)
        {
            int lengthArray = enterValue("Введите длину массива");
            int minArray = enterValue("Введите минимальное значение массива");
            int maxArray = enterValue("Введите максимальное значение массива");

            var array = createRandomArray(lengthArray, minArray, maxArray);
            printArray(array);
            var newArray = copyArray(array);
            printArray(newArray);
            Console.ReadKey();
        }
    }
}

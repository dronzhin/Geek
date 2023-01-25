using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//В одномерном массиве состоящий из целых чисел произвести следующие действия
//    1. Удалить из массива все четные числа
//    2. Удалить из массива все максимальные элементы

namespace task1
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
        static void printArray(string str, int[] array)
        {
            Console.WriteLine(str);
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
        static int[] deleteEvenValue(int[] array)
        {
            int length = array.Length;
            var newArray = new int[0];
            for (int i = 0; i < length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Array.Resize(ref newArray, newArray.Length+1);
                    newArray[newArray.Length - 1] = array[i];
                }
            }
            return newArray;
        }
        static int[] deleteAllMaxValue(int[] array)
        {
            int length = array.Length;
            int maxValue = array.Max();
            var newArray = new int[0];
            for (int i = 0; i < length; i++)
            {
                if (array[i] != maxValue)
                {
                    Array.Resize(ref newArray, newArray.Length + 1);
                    newArray[newArray.Length - 1] = array[i];
                }
            }
            return newArray;
        }
        static void Main(string[] args)
        {
            int length = enterValue("Введите величину массива");
            var array = createRandomArray(length, 0, 10);
            printArray("Сгенерированный массив", array);
            var arrayWithoutEvenValue = deleteEvenValue(array);
            printArray("Массив без четных чисел", arrayWithoutEvenValue);
            var arrayWithoutMaxValue = deleteAllMaxValue(array);
            printArray("Массив без всех максимальных значений", arrayWithoutMaxValue);


            Console.ReadKey();
        }
    }
}

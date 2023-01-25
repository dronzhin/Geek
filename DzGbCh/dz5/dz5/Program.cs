using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

namespace dz5
{
    internal class Program
    {
        static int EnterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] CreateRandomArray(int length, int min, int max)
        {
            Random rnd = new Random();
            var array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = rnd.Next(min, max);
            return array;
        }
        static void PrintArray(string str, int[] array)
        {
            Console.WriteLine(str);
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
        static int CountEvenValue(int[] array)
        {
            int countPositiveValue = 0;
            int length = array.Length;
            for (int i = 0; i < length; i++)
                if (array[i]%2 == 0) countPositiveValue++;
            return countPositiveValue;
        }
        static int SummOddIndexValue(int[] array)
        {
            int summOddValue = 0;
            int length = array.Length;
            for (int i = 1; i < length; i++)
            {
                summOddValue += array[i];
                i++;
            }
            return summOddValue;
        }
        static void Main(string[] args)
        {
            int lengthArray = EnterValue("Введите длину массива");
            int minArray = EnterValue("Введите минимальное значение массива");
            int maхArray = EnterValue("Введите максимальное значение массива");
            int [] myArray = CreateRandomArray(lengthArray, minArray, maхArray);
            PrintArray("Массив трехзначных цифр", myArray);
            Console.WriteLine("Количество четных значений - " + CountEvenValue(myArray));
            Console.WriteLine("Сумма значений под нечетными индексами - " + SummOddIndexValue(myArray));
            Console.WriteLine("Разница между максимум и минимум массива равна - " + (myArray.Max() - myArray.Min()));
            Console.ReadKey();
        }
    }
}

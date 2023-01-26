using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            //m = 3, n = 4.
            //0,5 7 -2 -0,2
            //1 -3,3 8 -9,9
            //8 7,8 -7,1 9

            int line = Methods.GetValue("Введите количество строк массива");
            int column = Methods.GetValue("Введите количество столбцов массива");
            double[,] userArray1 = Methods.CreateRandom2Array(line, column, max: 10.0, min: -10);
            Methods.PrintTwoDimensionalArray(userArray1);

            //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //17->такого числа в массиве нет

            Console.WriteLine();
            double[,] userArray2 = Methods.CreateRandom2Array(line, column, max: 10.0, min: 1, valueRound: 0);
            Methods.PrintTwoDimensionalArray(userArray2);
            double findNumber = Methods.GetValue("Введите число, которое хотите найти в массиве");
            double result = Methods.FindValueTwoDimensionalArray(userArray2, findNumber);
            Console.WriteLine();
            if (result == -1)
            {
                Console.WriteLine($"Число {findNumber} нет в заданном массиве");
            }
            else
            {
                Console.WriteLine($"Число {findNumber} есть в заданном массиве");
            }

            //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

            Console.WriteLine();
            Methods.AverageRowColumn2Array(userArray2, column: 1);
            Console.WriteLine();

        }
    }
}

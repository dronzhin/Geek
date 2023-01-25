using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line = Methods.GetValue("Введите количество строк массива");
            int column = Methods.GetValue("Введите количество столбцов массива");
            double[,] userArray = Methods.CreateRandomTwoDimensionalArray(line, column);
            Methods.PrintTwoDimensionalArray(userArray);

        }
    }
}

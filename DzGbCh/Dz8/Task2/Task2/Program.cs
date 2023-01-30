using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    internal class Program
    {
        enum hhhj
        {

        }
        static void Main(string[] args)
        {
            //Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
            //Например, на выходе получается вот такой массив:
            //01 02 03 04
            //12 13 14 05
            //11 16 15 06
            //10 09 08 07

            MethodsDZ.ShowFunnelOfNumbers(row: 10, column: 10);

            //Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //В итоге получается вот такой массив:
            //7 4 2 1
            //9 5 3 2
            //8 4 4 2

            int[,] user2Array = Methods.CreateRandom2Array(row: 3, column: 4, max: 10);
            user2Array = MethodsDZ.SortingAllStringByReduction2Array(user2Array);
            Methods.Print2Array(user2Array);

            //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //5 2 6 7
            //Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

            Console.WriteLine($"{MethodsDZ.FindStringWithMinSumm(user2Array)} строка с минимальной суммой");

            //Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
            //Например, даны 2 матрицы:
            //2 4 | 3 4
            //3 2 | 3 3
            //Результирующая матрица будет:
            //18 20
            //15 18

            Console.WriteLine();
            int[,] user2Array1 =
            {
                {2, 4},
                {3, 2}
            };
            int[,] user2Array2 =
            {
                {3, 4},
                {3, 3}
            };
            Methods.Print2Array(MethodsDZ.Multiplication2Matrices(user2Array1,user2Array2));

            //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
            //Массив размером 2 x 2 x 2
            //66(0, 0, 0) 25(0, 1, 0)
            //34(1, 0, 0) 41(1, 1, 0)
            //27(0, 0, 1) 90(0, 1, 1)
            //26(1, 0, 1) 55(1, 1, 1)

            int[,,] array = Methods.CreateUniqueRandom3Array(row: 2, column: 2, list: 2, max: 100, min: 0);
            MethodsDZ.Show3Array(array);

            Console.ReadKey();
        }
    }
}

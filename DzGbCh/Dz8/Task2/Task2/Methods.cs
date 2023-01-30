using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Methods
    {
        public static int GetValue(string message)
        {
            Console.Write(message + " : ");
            return int.Parse(Console.ReadLine());
        }
        public static int[] CreateRandomArray(int row, int max = 100, int min = 0)
        {
            Random random = new Random();
            int[] array = new int[row];
            for (int i = 0; i < row; i++)
            {
                    array[i] = random.Next(min, max);
            }
            return array;
        }
        public static double[,] CreateRandom2Array(int row, int column, double max = 100, double min = 0, int valueRound = 1)
        {
            Random random = new Random();
            double[,] array = new double[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = Math.Round(min + random.NextDouble() * (max - min));
                }
            }
            return array;
        }
        public static int[,] CreateRandom2Array(int row, int column, int max = 100, int min = 0)
        {
            Random random = new Random();
            int[,] array = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(min, max);
                }
            }
            return array;
        }
        public static int[,,] CreateRandom3Array(int row, int column, int list, int max = 100, int min = 0)
        {
            Random random = new Random();
            int[,,] array = new int[row, column, list];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int k = 0; k < list; k++)
                    {
                        array[i, j, k] = random.Next(min, max);
                    }
                }
            }
            return array;
        }
        public static int[,,] CreateUniqueRandom3Array(int row, int column, int list, int max = 100, int min = 0)
        {
            Random random = new Random();
            int[,,] array = new int[row, column, list];
            int[] randomArray = null;
            int length = row * column * list;
            while (true)
            {
                randomArray = CreateRandomArray(length * 5, max, min);
                randomArray = randomArray.Distinct().ToArray();
                if (randomArray.Length > length)
                {
                    break;
                }
            }
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    for (int k = 1; k <= list; k++)
                    {
                        array[i - 1, j - 1, k - 1] = randomArray[(i * j * k) - 1];
                    }
                }
            }
            return array;
        }
        public static void Print3Array<T>(T[,,] array)
        {
            int row = array.GetLength(0);
            int column = array.GetLength(1);
            int list = array.GetLength(2);
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("Плоскость - " + (i + 1));
                for (int j = 0; j < column; j++)
                {
                    for (int k = 0; k < list; k++)
                    {
                        Console.Write(array[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static void Print2Array<T>(T[,] array)
        {
            int line = array.GetLength(0);
            int column = array.GetLength(1);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static void PrintArray<T>(T[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                    Console.Write(array[i] + "\t");
            }
        }

        /// <summary>
        /// Метод проверяет, есть ли число в массиве
        /// </summary>
        /// <param name="array"></param>
        /// <param name="findNumber">Число которое необходимо найти</param>
        /// <returns>Выводит -1, если нет числа. если есть выводит число, которое мы ищем</returns>
        public static double FindValueTwoDimensionalArray(double[,] array, double findNumber)
        {
            double result = -1;
            int line = array.GetLength(0);
            int column = array.GetLength(1);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (array[i,j] == findNumber) result = findNumber;
                }
            }
            return result;
        }
        /// <summary>
        ///  Метод выводит строку со средними аривметическими значениями.
        ///  Если column равен 1, то по колонкам.
        ///  Если row равен 1, то по строкам.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="column"></param>
        /// <param name="row"></param>
        public static void AverageRowColumn2Array(double[,] array, int column = 0, int row = 0) 
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            double result = 0;
            if (row == 1)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result += array[i, j];
                    }
                    result = Math.Round(result / rows, 1);
                    Console.Write(result + "\t");
                    result= 0;
                }
            }
            else if(column == 1) 
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result += array[i, j];
                    }
                    result = Math.Round(result / columns, 1);
                    Console.Write(result + "\t");
                }
            }
            else
            {
                Console.WriteLine("Не выбрано, что искать");
            }
        }
    }
}

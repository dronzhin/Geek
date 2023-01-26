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
        public static double[,] CreateRandom2Array(int line, int column, double max = 100, double min = 0, int valueRound = 1)
        {
            Random random = new Random();
            double[,] array = new double[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = Math.Round(min + random.NextDouble() * (max - min));
                }
            }
            return array;
        }
        public static int[,] CreateRandom2Array(int line, int column, int max = 100, int min = 0)
        {
            Random random = new Random();
            int[,] array = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(min, max);
                }
            }
            return array;
        }

        public static void PrintTwoDimensionalArray<T>(T[,] array)
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

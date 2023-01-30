using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    internal class MethodsDZ
    {
        public static void ShowFunnelOfNumbers(int row, int column)
        {
            int i = 0;
            int j = 0;
            int count = 0;
            int[,] array = new int[row, column];
            array[0, 0] = 1;
            for (; j < column - 1; j++)
            {
                array[i, j + 1] = array[i, j] + 1;
            }
            row -= 1;
            while (true)
            {
                for (; i < row; i++)
                {
                    array[i + 1, j] = array[i, j] + 1;
                }
                if (array[i, j - 1] != 0) break;

                for (; j > column - 1 - row + count; j--)
                {
                    array[i, j - 1] = array[i, j] + 1;
                }
                if (array[i - 1, j] != 0) break;
                row -= 1;

                for (; i > column - 1 - row; i--)
                {
                    array[i - 1, j] = array[i, j] + 1;
                }
                if (array[i, j + 1] != 0) break;

                for (; j < row; j++)
                {
                    array[i, j + 1] = array[i, j] + 1;
                }
                if (array[i + 1, j] != 0) break;
            }
            Methods.Print2Array(array);
            Console.WriteLine();
        }
        public static int[,] SortingStringByReduction2Array(int[,] array, int numberString)
        {
            int column = array.GetLength(1);
            int i = 0;
            int index = 0;
            bool checkExchange= false;
            for (; i < column - 1; i++)
            {
                for (int j = i; j < column - 1; j++)
                {
                    int saveValue = array[numberString, i];
                    if (array[numberString, i] < array[numberString,j + 1])
                    {
                        array[numberString, i] = array[numberString, j + 1];
                        index = j + 1;
                        checkExchange= true;
                    }
                    if (checkExchange)
                    {
                        array[numberString, index] = saveValue;
                        checkExchange= false;
                    }
                }
            }
            return array;
        }
        public static int[,] SortingAllStringByReduction2Array(int[,] array)
        {
            int row = array.GetLength(0);
            for (int i = 0; i < row; i++)
            {
                array = SortingStringByReduction2Array(array, i);
            }
            return array;
        }
        public static int FindStringWithMinSumm(int[,] array)
        {
            int row = array.GetLength(0);
            int column = array.GetLength(1);
            int minSumm = Int32.MaxValue;
            int indexMinSumm = 0;
            for (int i = 0; i < row; i++)
            {
                int summ = 0;
                for (int j = 0; j < column; j++)
                {
                    summ += array[i, j];
                }
                if (summ < minSumm)
                {
                    indexMinSumm = i;
                    minSumm = summ;
                }
            }
            return indexMinSumm + 1;
        }
        public static int[,] Multiplication2Matrices(int[,] matrix1, int[,] matrix2)
        {
            int row1 = matrix1.GetLength(0);
            int row2 = matrix2.GetLength(0);
            int column2 = matrix2.GetLength(1);
            int[,] result = new int[row1, column2];
            if (row1 != column2) 
            {
                Console.WriteLine("Произвести произведение двух матриц невозможно");
                return result;
            }
            else
            {
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < column2; j++)
                    {
                        int multi = 0;
                        for (int k = 0; k < row2; k++)
                        {
                            multi = multi + matrix1[i, k] * matrix2[k, j];
                        }
                        result[i, j] = multi;
                    }
                }
                return result;
            }
        }
        public static int[,,] ReplaceDuplicate3Array(int[,,] array)
        {
            Random random = new Random();
            int row = array.GetLength(0);
            int column = array.GetLength(1);
            int list = array.GetLength(2);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int k = 0; k < list; k++)
                    {
                     
                        array[i, j, k] = random.Next(100);
                    }
                }
            }
            return array;
        }
        public static void Show3Array(int[,,] array)
        {
            int row = array.GetLength(0);
            int column = array.GetLength(1);
            int list = array.GetLength(2);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int k = 0; k < list; k++)
                    {
                        Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
                    }
                }
            }
        }
    }

}

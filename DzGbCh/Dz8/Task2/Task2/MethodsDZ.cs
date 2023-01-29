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
            Methods.PrintTwoDimensionalArray(array);
            Console.WriteLine();
        }
    }
}

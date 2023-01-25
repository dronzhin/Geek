using System;
using System.Collections.Generic;
using System.Linq;
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
        public static double[,] CreateRandomTwoDimensionalArray(int line, int column, double max = 100, double min = 0, int valueRound = 1)
        {
            Random random = new Random();
            double[,] array = new double[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i,j] = Math.Round(Random.(min, max), valueRound);
                }
            }
            return array;
        }
        public static void PrintTwoDimensionalArray(double[,] array)
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
    }
}

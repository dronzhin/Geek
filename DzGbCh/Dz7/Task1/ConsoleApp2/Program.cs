using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public static double[,] CreateRandom2ArrayDouble(int line, int column, double max, double min, int valueRound)
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
        }
}

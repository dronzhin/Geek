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
        static void Main(string[] args)
        {
            //Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
            //Например, на выходе получается вот такой массив:
            //01 02 03 04
            //12 13 14 05
            //11 16 15 06
            //10 09 08 07

            MethodsDZ.ShowFunnelOfNumbers(row: 10, column: 10); 
        }
    }
}

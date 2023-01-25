using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static class Index
        {
            static public int i, j;
        }
        static int EnterValue(string str)
        {
            Console.Write(str + " - ");
            return int.Parse(Console.ReadLine());
        }
        static int[,] RandomArray(int str, int col)
        {
            int[,] array = new int[str,col];
            Random random = new Random();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = random.Next(10);
                }
            }
            return array;
        }
        static void ShowArray(int[,] array)
        {
            int str = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int str = EnterValue("Введите количество строк");
            int col = EnterValue("Введите количество столбцов");
            int[,] array = RandomArray(str, col);
            ShowArray(array);
            int remember;
            for (int i = 0; i < col; i++)
            {
                remember = array[0, i];
                array[0, i] = array[str - 1, i];
                array[str - 1, i] = remember;
            }
            Console.WriteLine();
            ShowArray(array);
            Console.WriteLine();

            int[,] newArray = new int[str, col];
            if (str != col)
            {
                Console.WriteLine("Поменять местами невозможно");
            }
            else
            {
                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        newArray[j, i] = array[i, j];
                    }
                }
                ShowArray(newArray);
            }
            Console.WriteLine();
            int[] answer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = 0; j < str; j++)
                {
                    for (int h = 0; h < col; h++)
                    {
                        if (array[j, h] == answer[i]) count++;
                    }
                }
                if (count > 0) Console.WriteLine($"{answer[i]} встречается {count} раз");
                count= 0;
            }
            int min = array[0,0];
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (min > array[i, j])
                    {
                        min= array[i, j];
                        Index.i = i; Index.j = j;
                    }
                }
            }
            int[,] newArray1 = new int[str - 1, col - 1];
            for (int i = 0; i < str - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if(i < Index.i && j < Index.j) newArray1[i, j] = array[i, j];
                    if(i < Index.i && j >= Index.j) newArray1[i, j] = array[i, j+1];
                    if(i >= Index.i && j < Index.j) newArray1[i, j] = array[i+1, j];
                    if(i >= Index.i && j >= Index.j) newArray1[i, j] = array[i+1, j+1];
                }
            }
            ShowArray(newArray1);
            Console.ReadKey();
        }          
    }
}

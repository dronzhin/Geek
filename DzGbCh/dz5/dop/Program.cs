using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать рамдомные 5 массивов и в каждом из них показывать число (реклама) с определенным интервалом, 
//учитывать этот интервал при переходе на следующий массив.

namespace dop
{
    internal class Program
    {
        static int EnterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] CreateRandomArray(int minLength, int maxLength)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int length = rnd.Next(minLength, maxLength);
            var array = Enumerable.Range(1, length).ToArray();
            return array;
        }
        static void PrintJaggedArray(int[][] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j] + " ");
                Console.WriteLine();
            }
        }
        static int PrintNewsAndGetRemains(int[] array, int frequencyNews, int Remains)
        {
            int length = array.Length;
            for (int i = Remains; i < length; i += frequencyNews)
                Console.WriteLine($"{array[i]} выпуске  показываем рекламу нашим жертвам");
            return frequencyNews - 1 - (length -1 - Remains) % frequencyNews;
        }
        static void Main(string[] args)
        {
            int numberArray = EnterValue("Введите количество массивов");
            int minLength = EnterValue("Введите минимальную длину массива");
            int maxLength = EnterValue("Введите максимальную длину массива");
            int[][] myArray = new int[numberArray][];
            for (int i = 0; i < numberArray; i++)
                myArray[i] = CreateRandomArray(minLength, maxLength);
            Console.WriteLine();
            Console.WriteLine("Текущий зубчатый массив");
            Console.WriteLine();
            PrintJaggedArray(myArray);
            Console.WriteLine();
            int frequencyNews = EnterValue("Введите с какой периодичностью должна выходить новость");
            Console.WriteLine();
            int remains = 0;
            for (int i = 1; i <= numberArray; i++)
            {
                Console.WriteLine("В массиве номер - " + i);
                remains = PrintNewsAndGetRemains(myArray[i-1], frequencyNews, remains);
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}

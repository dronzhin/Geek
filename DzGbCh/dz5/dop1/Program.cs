using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вывести все варианты чисел массива сумма которых была бы равна 0

namespace dop1
{
    internal class Program
    {
        static int EnterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] CreateRandomArray(int length, int min, int max)
        {
            Random rnd = new Random();
            var array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = rnd.Next(min, max);
            return array;
        }
        static void PrintArray(string str, int[] array)
        {
            Console.WriteLine(str);
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
        static void SummTwoValueEqualZero(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] + array[j] == 0) Console.WriteLine("{ " + array[i] + " " + array[j] + " }");
                }
            }
            Console.WriteLine();
        }
        static void SummValueEqualZero(int[] array)
        {
            int length = array.Length;
            if (length >= 2)
            {
                Console.WriteLine("Сумма чисел из двух элементов равна 0");
                for (int i1 = 0; i1 < length - 1; i1++)
                {
                    for (int i2 = i1 + 1; i2 < length; i2++)
                    {
                        if (array[i1] + array[i2] == 0) 
                            Console.WriteLine("{ " + array[i1] + " " + array[i2] + " }");
                    }
                }
                Console.WriteLine();
            }
            if (length >= 3)
            {
                Console.WriteLine("Сумма чисел из трех элементов равна 0");
                for (int i1 = 0; i1 < length - 1; i1++)
                {
                    for (int i2 = i1 + 1; i2 < length; i2++)
                    {
                        for (int i3 = i2 + 1; i3 < length; i3++)
                        {
                            if (array[i1] + array[i2] + array[i3] == 0) 
                                Console.WriteLine("{ " + array[i1] + " " + array[i2] + " " + array[i3] + " }");
                        }
                    }
                }
                Console.WriteLine();
            }
            if (length >= 4)
            {
                Console.WriteLine("Сумма чисел из 4 элементов равна 0");
                for (int i1 = 0; i1 < length - 1; i1++)
                {
                    for (int i2 = i1 + 1; i2 < length; i2++)
                    {
                        for (int i3 = i2 + 1; i3 < length; i3++)
                        {
                            for (int i4 = i3 + 1; i4 < length; i4++)
                            {
                                if (array[i1] + array[i2] + array[i3] +  array[i4] == 0) 
                                    Console.WriteLine("{ " + array[i1] + " " + array[i2] + " " + array[i3] + " " + array[i4] + " }");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            if (length >= 5)
            {
                Console.WriteLine("Сумма чисел из 5 элементов равна 0");
                for (int i1 = 0; i1 < length - 1; i1++)
                {
                    for (int i2 = i1 + 1; i2 < length; i2++)
                    {
                        for (int i3 = i2 + 1; i3 < length; i3++)
                        {
                            for (int i4 = i3 + 1; i4 < length; i4++)
                            {
                                for (int i5 = i4 + 1; i5 < length; i5++)
                                    if (array[i1] + array[i2] + array[i3] + array[i4] + array[i5] == 0)
                                    Console.WriteLine("{ " + array[i1] + " " + array[i2] + " " + array[i3] + " " + array[i4] + " "
                                        + array[i5] + " }");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            if (length >= 6)
            {
                Console.WriteLine("Сумма чисел из 6 элементов равна 0");
                for (int i1 = 0; i1 < length - 1; i1++)
                {
                    for (int i2 = i1 + 1; i2 < length; i2++)
                    {
                        for (int i3 = i2 + 1; i3 < length; i3++)
                        {
                            for (int i4 = i3 + 1; i4 < length; i4++)
                            {
                                for (int i5 = i4 + 1; i5 < length; i5++)
                                {
                                    for(int i6 = i5 + 1; i6 < length; i6++)
                                    if (array[i1] + array[i2] + array[i3] + array[i4] + array[i5] + array[i6] == 0)
                                        Console.WriteLine("{ " + array[i1] + " " + array[i2] + " " + array[i3] + " " + array[i4] + " "
                                            + array[i5] + " " + array[i6] + " }");
                                }
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            if (length >= 7)
            {
                Console.WriteLine("Сумма чисел из 7 элементов равна 0");
                Console.WriteLine();
                for (int i1 = 0; i1 < length - 1; i1++)
                {
                    for (int i2 = i1 + 1; i2 < length; i2++)
                    {
                        for (int i3 = i2 + 1; i3 < length; i3++)
                        {
                            for (int i4 = i3 + 1; i4 < length; i4++)
                            {
                                for (int i5 = i4 + 1; i5 < length; i5++)
                                {
                                    for (int i6 = i5 + 1; i6 < length; i6++)
                                    {
                                        for (int i7 = i6 + 1; i7 < length; i7++)
                                            if (array[i1] + array[i2] + array[i3] + array[i4] + array[i5] + array[i6] + array[i7] == 0)
                                                Console.WriteLine("{ " + array[i1] + " " + array[i2] + " " + array[i3] + " " + array[i4] + " "
                                                    + array[i5] + " " + array[i6] + " " + array[i7] + " }");
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine();
            }



        }
        static void Main(string[] args)
        {
            int length = EnterValue("Введите длину массива");
            int[] array = CreateRandomArray(length, -50, 50);
            PrintArray("Созданный массив", array);
            SummValueEqualZero(array);
            Console.ReadKey();
        }
    }
}

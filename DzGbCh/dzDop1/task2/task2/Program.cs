using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Для каждой строки посчитать количество значений, которые больше заданного числа. Вывести количество в одномерный массив
// 2. Для каждого столбца найти первый положительный элемент и записать в массив
// 3. Удалите все столбцы у которых четное количество нечетных элементов
// 4. Удалить строки, в которых каждый элемент попадает попадает в заданный массив
// 5. Удалить строки, у которых все элементы положительные
namespace task2
{
    internal class Program
    {
        static int enterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[,] createRandomTwoDimensionalArray(int countString, int countСolumn,  int minValue = 0, int maxValue = 100)
        {
            var array = new int[countString, countСolumn];
            Random random = new Random();
            for (int i = 0; i < countString; i++)
            {
                for (int j = 0; j < countСolumn; j++)
                {
                    array[i , j] = random.Next(minValue, maxValue);
                }
            }
            return array;
        }
        static void printArray(string str, int[] array)
        {
            Console.WriteLine(str);
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
        static void printTwoDimensionalArray(string str, int[,] array)
        {
            int countString = array.GetLength(0);
            int countСolumn = array.GetLength(1);
            Console.WriteLine(str);
            for (int i = 0; i < countString; i++)
            {
                for (int j = 0; j < countСolumn; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int[] countValueMoreThanNumber(int[,] array, int number)
        {
            int countString = array.GetLength(0);
            int countСolumn = array.GetLength(1);
            int[] newArray = new int[countString];

            for (int i = 0; i < countString; i++)
            {
                int countValue = 0;
                for (int j = 0; j < countСolumn; j++)
                {
                    if (array[i, j] > number) countValue++;
                }
                newArray[i] = countValue;
            }
            return newArray;
        }
        static int[] createArrayValueMoreThanZero(int[,] array)
        {
            int countString = array.GetLength(0);
            int countСolumn = array.GetLength(1);
            int[] newArray = new int[countСolumn];

            for (int i = 0; i < countСolumn; i++)
            {
                for (int j = 0; j < countString; j++)
                {
                    if (array[j, i] > 0)
                    {
                        newArray[i] = array[j, i];
                        break;
                    }
                    else
                    {
                        newArray[i] = -1;
                    }
                }
            }
            return newArray;
        }
        static int[,] deleteColumnArray(int[,] array, int indexColumn)
        {
            int countString = array.GetLength(0);
            int countСolumn = array.GetLength(1);
            int[,] newArray = new int[countString, countСolumn-1];
            for (int i = 0; i < countString; i++)
            {
                for (int j = 0; j < countСolumn-1; j++)
                {
                    if (j >= indexColumn)
                    {
                        newArray[i, j] = array[i, j+1];
                    }
                    else
                    {
                        newArray[i, j] = array[i, j];
                    }
                }
            }
            return newArray;
        }
        static int[] findOddnumberColumn(int[,] array)
        {
            int countString = array.GetLength(0);
            int countСolumn = array.GetLength(1);
            int[] newArray = new int[countСolumn];

            for (int i = 0; i < countСolumn; i++)
            {
                int countOddValue = 0;
                for (int j = 0; j < countString; j++)
                    if (array[j, i] % 2 == 1) countOddValue++;
                newArray[i] = (countOddValue % 2 == 0) ? 0 : 1;
            }
            return newArray;
        }
        static int[,] deleteStringArray(int[,] array, int indexString)
        {
            int countString = array.GetLength(0);
            int countСolumn = array.GetLength(1);
            int[,] newArray = new int[countString - 1, countСolumn];
            for (int i = 0; i < countСolumn; i++)
            {
                for (int j = 0; j < countString - 1; j++)
                {
                    if (j >= indexString)
                    {
                        newArray[j, i] = array[j + 1, i];
                    }
                    else
                    {
                        newArray[j, i] = array[j, i];
                    }
                }
            }
            return newArray;
        }
        static int[] findStrintInDefinedRange(int[,] array, int minRange, int maxRange)
        {
            int countString = array.GetLength(0);
            int countСolumn = array.GetLength(1);
            int[] newArray = new int[countString];

            for (int i = 0; i < countString; i++)
            {
                for (int j = 0; j < countСolumn; j++)
                    if (array[i, j] < minRange || array[i, j] > maxRange)
                    {
                        newArray[i] = 1;
                        break;
                    }
            }
            return newArray;
        }
        static int[,] deleteAllStringInCondition(int[,] array, int[] arrayCondition)
        {
            int countIndex = 0;
            int countString = array.GetLength(0);
            for (int i = 0; i < countString; i++)
            {
                if (arrayCondition[i] == 0)
                {
                    array = deleteStringArray(array, i - countIndex);
                    countIndex++;
                }
            }
            return array;
        }
        static int[,] deleteAllColumnInCondition(int[,] array, int[] arrayCondition)
        {
            int countIndex = 0;
            int countСolumn = array.GetLength(1);
            for (int i = 0; i < countСolumn; i++)
            {
                if (arrayCondition[i] == 0)
                {
                    array = deleteColumnArray(array, i - countIndex);
                    countIndex++;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int countString = enterValue("Введите количество строк массива");
            int countСolumn = enterValue("Введите количество столбцов массива");
            var array = createRandomTwoDimensionalArray(countString, countСolumn, -15, 30);
            printTwoDimensionalArray("Двумерный массив", array);
            int userNumber = enterValue("Введите число, больше которого необходимо посчитать");
            printArray("Количество значений больше заданного числа", countValueMoreThanNumber(array, userNumber));
            printArray("Первое значение больше 0", createArrayValueMoreThanZero(array));
            var newArray1 = findOddnumberColumn(array);
            printArray("Проверка на четность нечетных элементов", newArray1);
            int[,] newArray2 = deleteAllColumnInCondition(array, newArray1);
            printTwoDimensionalArray("Массив после удаления столбцов, где четно нечетных цифр", newArray2);
            var newArray3 = findStrintInDefinedRange(array, -5, 30);
            printArray("Проверка на строки, где все числа в диапазоне -5 до 30", newArray3);
            var newArray4 = deleteAllStringInCondition(array, newArray3);
            printTwoDimensionalArray("Удаление строк, где все числа в диапазоне -5 до 30", newArray4);
            var newArray5 = findStrintInDefinedRange(array, 0, 30);
            printArray("Проверка на строки, где все числа положительные", newArray5);
            var newArray6 = deleteAllStringInCondition(array, newArray5);
            printTwoDimensionalArray("Удаление строк, где все числа положительные", newArray6);
            Console.ReadKey();
        }
    }
}

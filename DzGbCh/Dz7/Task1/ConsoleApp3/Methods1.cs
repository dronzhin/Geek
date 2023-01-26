using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Methods1
    {
        public static void PrintArray<T1>(T1[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Суммирует два числа
        /// </summary>
        /// <param name="a">просто число</param>
        /// <param name="b">Хорошее</param>
        /// <returns>Ответ</returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static double Sum(double a, int b)
        {
            return a + b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

namespace dop.task5
{

    internal class Program
    {
        static int enterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int convertToBinary(int value)
        {
            var array = new byte[0];
            for (int i = 0; value > 0; i++)
            {
                Array.Resize(ref array, i + 1);
                array[i] = (byte)(value%2);
                value /= 2;
            }
            Array.Reverse(array);
            return Convert.ToInt32(string.Join("",array));
        }
        static void Main(string[] args)
        {
            int number = enterValue("Введите число");
            Console.WriteLine($"Число {number} в двоичном измерении равен {convertToBinary(number)}");
            Console.ReadKey();
        }
    }
}

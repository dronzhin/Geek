using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

namespace task2
{
    internal class Program
    {
        static int EnterValue(string message)
        {
            Console.Write(message + " - ");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int value))
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число, введите число");
                    }
            }
        }
        static void Main(string[] args)
        {
            double b1 = EnterValue("Введите значение b1");
            double b2 = EnterValue("Введите значение b2");
            double k1 = EnterValue("Введите значение k1");
            double k2 = EnterValue("Введите значение k2");
            if(k1 == k2)
            {
                Console.WriteLine("Линии не пересекаются");
            }
            else
            {
                double x = (b1 - b2) / (k2 - k1);
                double y = x * k1 + b1;
                Console.WriteLine($"Точка пересечения х = {x} и у = {y}");
            }
        }
    }
}

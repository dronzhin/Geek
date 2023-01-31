using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.
            //N = 5-> "5, 4, 3, 2, 1"
            //N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

            MethodsDZ.PrintReduceValue(10);
            Console.WriteLine();

            //Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            //M = 1; N = 15-> 120
            //M = 4; N = 8. -> 30

            Console.WriteLine(MethodsDZ.SummNumberBetweenValue(1, 15));

            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            //m = 2, n = 3->A(m, n) = 9
            //m = 3, n = 2->A(m, n) = 29

            int m = 2;
            int n = 3;
            Console.WriteLine($"A({m}, {n}) = " + MethodsDZ.FunAccerman(3,2));
        }
    }
}

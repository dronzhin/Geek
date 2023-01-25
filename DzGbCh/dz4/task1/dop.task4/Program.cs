using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//❗ Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

namespace dop.task4
{
    internal class Program
    {
        static int enterValue(string message)
        {
            Console.Write(message + " - ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static bool checkExistenceOfTriangle(int sideA, int sideB, int sideC)
        {
            return sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB;

        }
        static void Main(string[] args)
        {
            int sideA = enterValue("Введите первую сторону треугольника");
            int sideB = enterValue("Введите вторую сторону треугольника");
            int sideC = enterValue("Введите третью сторону треугольника");
            Console.WriteLine(checkExistenceOfTriangle(sideA,sideB,sideC) ? "Треугольник" : "Не треугольник");
            Console.ReadKey();
        }
    }
}

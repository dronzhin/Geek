using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    internal class MethodsDZ
    {
        public static void PrintReduceValue(int n)
        {
            if (n == 0) return;
            Console.Write(n + " ");
            PrintReduceValue(n - 1);
        }
        public static int SummNumberBetweenValue(int number1, int number2)
        {
            if (number1 == number2) return number1;
            return SummNumberBetweenValue(number1, number2 - 1) + number2;
        }
        public static int FunAccerman(int m, int n)
        {
            if (m == 0) return n + 1;
            if ((m > 0) && (n == 0)) return FunAccerman(m - 1, 1);
            return FunAccerman(m - 1, FunAccerman(m, n - 1));
        }
    }
}

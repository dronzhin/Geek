using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        static int Fib(int n, ref int summ)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            summ += Fib(n - 1, ref summ) + Fib(n - 2, ref summ);
            return Fib(n - 1, ref summ) + Fib(n-2, ref summ);
        }
        static void Main(string[] args)
        {
            int sum = 0;
            int fib = Fib(5, ref sum);
            Console.WriteLine(sum);
        }
    }
}

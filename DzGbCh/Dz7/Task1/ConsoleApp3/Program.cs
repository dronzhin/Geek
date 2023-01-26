using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint[] array = { 1, 2, 3};
            int a = 2; int b = 3;
            int c = Methods1.Sum(a, b);
            Methods1.PrintArray(array);
        }
    }
}

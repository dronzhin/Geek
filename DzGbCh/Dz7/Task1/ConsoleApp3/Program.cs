using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1;

namespace ConsoleApp3
{
    internal class Program
    {
        public static int sum( ref int a, int b)
        {
            a++;
            return b;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = sum(ref a, b);
            Console.WriteLine(a);

            
        }
    }
}

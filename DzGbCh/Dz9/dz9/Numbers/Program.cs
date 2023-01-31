using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            string result = Console.ReadLine();
            result = Method.SplitString(result, ref summ);
            Console.WriteLine($"Сумма равна {summ}");
            Console.WriteLine(result);
        }
    }
}

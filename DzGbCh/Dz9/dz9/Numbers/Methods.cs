using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public static class Method
    {
        public static string SmallSplitString(string s, ref int summ, int bigNumber, int middleNumber, int smallNumber, string big, string middle, string small)
        {
            string result = string.Empty;
            while (true)
            {
                if (s.Contains(small + big)) 
                { 
                    summ += bigNumber - smallNumber;
                    result += small + big + $" - {bigNumber - smallNumber}, ";
                    break;
                }
                if (s.Contains(middle + small + small + small))
                {
                    summ += bigNumber - smallNumber * 2;
                    result += middle + small + small + small + $" - {bigNumber - smallNumber * 2}, ";
                    break;
                }
                if (s.Contains(middle + small + small))
                {
                    summ += bigNumber - smallNumber * 3;
                    result += middle + small + small + $" - {bigNumber - smallNumber * 3}, ";
                    break;
                }
                if (s.Contains(middle + small))
                {
                    summ += bigNumber - smallNumber * 4;
                    result += middle + small + $" - {bigNumber - smallNumber * 4}, ";
                    break;
                }
                if (s.Contains(small + middle))
                {
                    summ += middleNumber - smallNumber;
                    result += small + middle + $" - {middleNumber - smallNumber}, ";
                    break;
                }
                if (s.Contains(small + small + small))
                {
                    summ += middleNumber - smallNumber * 2;
                    result += small + small + small + $" - {middleNumber - smallNumber * 2}, ";
                    break;
                }
                if (s.Contains(small + small))
                {
                    summ += middleNumber - smallNumber * 3;
                    result += small + small + $" - {middleNumber - smallNumber * 3}, ";
                    break;
                }
                if (s.Contains(small))
                {
                    summ += middleNumber - smallNumber * 4;
                    result += small + $" - {middleNumber - smallNumber * 4}, ";
                    break;
                }
                if (s.Contains(middle))
                {
                    summ += middleNumber;
                    result += middle + $" - {middleNumber}, ";
                    break;
                }
                break;
            }
            return result;
        }
        public static string SplitString(string s, ref int summ)
        {
            string result = null;
            result += SmallSplitString(s, ref summ, 10000, 5000, 1000, "V!", "V!", "M");
            result += SmallSplitString(s, ref summ, 1000, 500, 100, "M", "D", "C");
            result += SmallSplitString(s, ref summ, 100, 50, 10, "C", "L", "X");
            result += SmallSplitString(s, ref summ, 10, 5, 1, "X", "V", "I");
            return result;
        }
    }
}

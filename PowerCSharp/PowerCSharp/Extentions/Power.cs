using System;
using System.Collections.Generic;
using System.Text;

namespace PowerCSharp.Extentions
{
    public static class Power
    {
        public static double PowNums(this int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}

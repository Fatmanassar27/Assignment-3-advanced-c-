using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Delegate
{
    internal class Condtions
    {
        public static bool GetOddNum (int x)
        {
            return x % 2 == 1;
        }
        public static bool GetEvenNum(int x)
        {
            return x % 2 == 0;
        }
        public static bool GetNumDivisableBy7(int x)
        {
            return x % 7 == 0;
        }
        public static bool GetNumDivisableBy10(int x)
        {
            return x % 10 == 0;
        }
        public static bool GetStringLength(string x)
        {
            return x?.Length > 4;
        }
    }
}

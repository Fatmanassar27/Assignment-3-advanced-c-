using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ComparaFunctions
    {
        public static bool CompareGret(int x, int y)
            { return x < y; }
        public static bool Compareless(int x, int y)
                { return x > y; }
        public static bool CompareLengthAscending(string x, string y)
        { return x.Length < y.Length; }
        public static bool CompareLengthDscending(string x, string y)
        { return x.Length > y.Length; }
    }
}

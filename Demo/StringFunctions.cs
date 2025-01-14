﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringFunctions
    {
        public static int GetUpperChars (string str)
        {
            int count = 0;
            if (str != null ) 
                for ( int i = 0; i < str.Length; i++ )
                    if (char.IsUpper ( str[i] ) )
                         count++;
            return count;
        } 
        public static int GetLowerChars (string str)
        {
            int count = 0;
            if (str != null ) 
                for ( int i = 0; i < str.Length; i++ ) 
                    if (char.IsLower ( str[i] ) )
                        count++;
            return count;
        }
    }
}

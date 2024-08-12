﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   
    public class BookFunctions
    {
        public static string GetTitle (Book B )
        { return B.Title; }
        public static string GetAuthors (Book B )
        {
                  return B?.Author.ToString() ?? string.Empty;
        }
        public static string GetPrice (Book B )
        { return B.Price.ToString(); }
       

    }
}
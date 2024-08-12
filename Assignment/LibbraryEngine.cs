using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class LibbraryEngine
    {
        public static void ProcessBooks (List<Book> blist,Func<Book , string> fptr )
        {
            foreach (Book b in blist)
                Console.WriteLine(fptr(b));
        }
    }
}

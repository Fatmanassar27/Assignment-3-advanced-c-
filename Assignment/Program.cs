using System.Text.RegularExpressions;

namespace Assignment
{

    internal class Program
    {
        public delegate string Title(Book book);
        static void Main(string[] args)
        {
            #region Part 1
            //string[] strings = { "ahmed", "amr", "mona" };
            //DateTime dateTime = DateTime.Now;
            //Book book = new Book("4581", "Data", strings, dateTime, 500.0M);
            //Console.WriteLine(book.ToString());

            ////uesr defined delegate
            //Title title = BookFunctions.GetTitle;
            //Console.WriteLine(title.Invoke(book));

            ////build in delegate
            //Func<Book, string> func = BookFunctions.GetPrice;
            //Console.WriteLine(func.Invoke(book));

            ////anonymous methodw
            //Func<Book, string> func1 = delegate (Book book) { return book.ISBN; };
            //Console.WriteLine(func1.Invoke(book));

            ////lambda expression
            //Action<Book> action = (b) => Console.WriteLine(b.PublicationDate);
            //action(book);
            #endregion

            #region Part 2
            //string[] strings = { "ahmed", "amr", "mona" };
            //DateTime dateTime = DateTime.Now;
            ////Book book = new Book;
            //List<Book> books = new List<Book>()
            //{
            //  new Book("4581", "Data Base", strings, dateTime, 500.0M) ,
            //  new Book("2852", "backend", strings, dateTime, 400.0M) ,
            //  new Book("4356", "MVC", strings, dateTime, 800.0M) ,
            //  new Book("5451", "API", strings, dateTime, 600.0M) ,
            //};

            //bool isexist = books.Exists((Book b) => b.ISBN =="4356");
            //Console.WriteLine(isexist);

            //Book book = books.Find((Book b) => b.ISBN == "4356") ;
            //Console.WriteLine(book.ToString());

            //List<Book> list = books.FindAll((Book b) => b.Price > 500.0m);
            //Console.WriteLine(list.Count);

            //int index = books.FindIndex((Book b) => b.ISBN == "2852");
            //Console.WriteLine(index);

            //book = books.FindLast((Book b) => b.Price > 500.0m);
            //Console.WriteLine(book.ToString());

            //index = books.FindLastIndex((Book b) => b.Price > 500.0m);
            //Console.WriteLine(index);

            //books.ForEach((Book b) => Console.WriteLine(b.Price+500.0m));

            //bool istrue = books.TrueForAll((Book b) => b.Price > 200.0m);
            //Console.WriteLine(istrue);
            #endregion
        }
    }
}

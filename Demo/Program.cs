using Demo.Delegate;
using System.Xml.Linq;

namespace Demo
{
    internal class Program
    {
        //public delegate int delegateFuc(string str);
       
        static void Main(string[] args)
        {
            #region part 0
            //Func<string,int> delegateFuc;
            //delegateFuc = StringFunctions.GetUpperChars;
            //int Result = delegateFuc.Invoke("AhMed KaMal");
            //Console.WriteLine(Result);
            //delegateFuc += StringFunctions.GetLowerChars;
            //Result = delegateFuc.Invoke("AhMed KaMal");
            //Console.WriteLine(Result);
            //delegateFuc -= StringFunctions.GetLowerChars;
            //Result = delegateFuc.Invoke("AhMed KaMal");
            //Console.WriteLine(Result);
            #endregion

            #region part 1
            //int[] ints = { 37, 15, 5, 81, 58, 7, 8, 54, 5 };
            //FunctionsAlgorithms.BubbleSort(ints, ComparaFunctions.CompareGret);
            //foreach (int i in ints)
            //    Console.WriteLine(i);
            //FunctionsAlgorithms.BubbleSort(ints, ComparaFunctions.Compareless);
            //foreach (int i in ints)
            //    Console.WriteLine(i);
            #endregion

            #region part 2
            //string[] strings = { "Ahmed", "Ali", "Fatima", "Mohamed" };
            //FunctionsAlgorithms<string>.BubbleSort(strings, ComparaFunctions.CompareLengthDscending);
            //foreach (string str in strings)
            //    Console.WriteLine(str);
            #endregion

            #region part 3
            //List<int> list = Enumerable.Range(1, 100).ToList();
            //Console.WriteLine("OOD NUMBERS");
            //List<int> odd = Helper.GetNum(list, Condtions.GetOddNum);
            //foreach (int i in odd)
            //    Console.Write(" " + i);


            //Console.WriteLine("\nEVEN NUMBERS");
            //List<int> EVEN = Helper.GetNum(list, Condtions.GetEvenNum);
            //foreach (int i in EVEN)
            //    Console.Write(" " + i);


            //Console.WriteLine("\nNUMBERS DIVIDED BY 7");
            //List<int> divisableby7 = Helper.GetNum(list, Condtions.GetNumDivisableBy7);
            //foreach (int i in divisableby7)
            //    Console.Write(" " + i);


            //Console.WriteLine("\nNUMBERS DIVIDED BY 10");
            //List<int> divisableby10 = Helper.GetNum(list, Condtions.GetNumDivisableBy10);
            //foreach (int i in divisableby10)
            //    Console.Write(" " + i);
            #endregion

            #region part 4
            //List<string> list = new List<string> { "Ahmed", "Ali", "Fatima", "Mohamed" ,"omar"};
            //List<string> strings = Helper.GetElement(list , Condtions.GetStringLength);
            //foreach (string str in strings) 
            //    Console.WriteLine(str);
            #endregion

            #region part 5
            //Predicate<int> predicate;
            //predicate = Testfunction.Test01;
            //Console.WriteLine(predicate.Invoke(5));

            //Func<int , string> func;
            //func = Testfunction.Test02;
            //Console.WriteLine(func.Invoke(5));

            //Action action;
            //action = Testfunction.Test03;
            //action.Invoke();

            //Action<string> action1 = Testfunction.Test04;
            //action1.Invoke("fatma");

            #endregion

            #region part 6
            //Predicate<int> predicate;
            //predicate = delegate (int x) { return x > 0; };
            //predicate = (x) => x> 0;
            //Console.WriteLine(predicate(5));

            //Func<int , string> func;
            //func = delegate (int x) { return x.ToString(); };
            //func = x => x.ToString();
            //Console.WriteLine(func(5));

            //Action action;
            //action = delegate { Console.WriteLine("Hello"); };
            //action = () => Console.WriteLine("Hello");
            //action.Invoke();

            //Action<string> action1;
            //action1 = delegate (string Name){ Console.WriteLine($"Hello {Name}");};
            //action1 = (Name) => Console.WriteLine($"Hello {Name}");
            //action1.Invoke("fatma");
            #endregion

            #region part 7
            //var predicate = delegate (int x) { return x > 0; };
            //predicate = (int x) => x > 0;
            //Console.WriteLine(predicate(5));

            //var func = delegate (int x) { return x.ToString(); };
            //func = x => x.ToString();
            //Console.WriteLine(func(5));

            //var action = delegate () { Console.WriteLine("Hello"); };
            //action = () => Console.WriteLine("Hello");
            //action.Invoke();

            //var action1 = delegate (string Name) { Console.WriteLine($"Hello {Name}"); };
            //action1 = (Name) => Console.WriteLine($"Hello {Name}");
            //action1.Invoke("fatma");
            #endregion

            #region part 8
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //foreach (int num in Numbers) 
            //    Console.Write($"{num} ");

            //Console.WriteLine("\n====================================");
            
            //List <int> evens = Numbers.FindAll(Num => Num % 2 == 0);
            //foreach (int num in evens)
            //    Console.Write($"{num} ");
            
            //Console.WriteLine("\n====================================");

            //int x = Numbers.Find(Num => Num % 2 == 1);
            //Console.WriteLine(x);

            //Console.WriteLine("\n====================================");

            //int index = Numbers.FindIndex(num => num % 5 == 0);
            //Console.WriteLine(index);

            //Console.WriteLine("\n====================================");

            //index = Numbers.FindLastIndex(num => num % 5 == 0);
            //Console.WriteLine(index);

            //Console.WriteLine("\n====================================");

            //index = Numbers.FindLast(num => num % 5 == 0);
            //Console.WriteLine(index);
            
            //Console.WriteLine("\n====================================");

            //Numbers.ForEach(Number => Console.Write($" {Number+10}"));

            //foreach (int num in Numbers)
            //    Console.Write($"{num} ");

            //Console.WriteLine("\n====================================");

            //Numbers.RemoveAll(num => num % 5 == 0); 

            //foreach (int num in Numbers)
            //    Console.Write($"{num} ");

            #endregion


        }
    }
    //public class Testfunction
    //{
    //    public static bool Test01(int x)
    //    { return x > 0; }
    //    public static string Test02(int x)
    //    { return x.ToString(); }
    //    public static void Test03()
    //    { Console.WriteLine("Hello"); }
    //    public static void Test04(string Name)
    //    { Console.WriteLine($"Hello {Name}"); }
    //}
}

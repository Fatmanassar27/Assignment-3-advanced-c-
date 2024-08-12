using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Delegate
{
    delegate bool Check<T>(T x);
    internal class Helper
    {
        //public static List<int> GetNum(List<int> arr ,Check check)
        //{
        //    List<int> list = new List<int>();
        //    if(arr is not  null && check is not null)
        //    {
        //        for (int i = 0; i < arr.Count; i++) 
        //            if (check(arr[i]))
        //                list.Add(arr[i]);
        //    }
        //    return list;
        //}
        public static List<T> GetElement <T>(List<T> arr ,Check<T> check)
        {
            List<T> list = new List<T>();
            if(arr is not  null && check is not null)
            {
                for (int i = 0; i < arr.Count; i++) 
                    if (check(arr[i]))
                        list.Add(arr[i]);
            }
            return list;
        }
    }
}

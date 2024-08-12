using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
   // public delegate TResult SortingDelegate<in T ,out TResult>(T a, T b);
    internal class FunctionsAlgorithms <T>
    {
        #region non genaric
        //public static void BubbleSort( int [] arr , SortingDelegate sorting)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length -1 - i; j++)
        //            {
        //                if (sorting(arr[j], arr[j+1]))
        //                    Swap (ref arr[j],ref arr[j+1]);
        //            }
        //        }
        //    }
        //}
        #endregion

        #region genaric
        public static void BubbleSort(T[] arr, Func<T,T,bool> sorting)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (sorting(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        #endregion
        private static void Swap(ref T v1, ref T v2)
        {
            (v1 , v2 ) = (v2 , v1 );
        }
    }
}

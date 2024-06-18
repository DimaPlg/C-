using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reterned.SortingArr
{
    internal class InserionSort
    {
        public static int[] Insert(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                for(int j = i;j > 0 && arr[j] < arr[j - 1];j--)
                    (arr[j], arr[j-1]) = (arr[j - 1], arr[j]);
            }
            return arr;
        }
    }
}

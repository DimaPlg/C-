using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reterned.SortingArr
{
    internal class ShakerSort
    {
        public static int[] Shaker(int[] arr) 
        {
            int len = arr.Length;
            for (int i = 0, j = len - 1; i != -1; i++, j--)
            {
                if (arr[i] > arr[i + 1])
                    (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
                if (arr[j] < arr[j - 1])
                    (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                if (i == len - 2 || j == 1)
                {
                    len--;
                    i = arr.Length - len;
                    j = len - 1;
                    if (j - i < 1)
                        i = -2;
                }
            }
            return arr;
        }
    }
}

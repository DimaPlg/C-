using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reterned.SortingArr
{
    internal class Bable
    {
        public static int RandValue(int min, int max) 
        {
            Thread.Sleep(6);
            Random rnd = new Random();
            return rnd.Next(min,max); 
        }

        public static int[] BableSort(int[] arr) 
        {
            int len = arr.Length;
            for (int i = 1; i < len; i++) 
            {
                if (arr[i] < arr[i - 1])
                    (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
                if (arr[i] == arr[i - 1])
                    continue;
                if(i == len - 1 && len > 1)
                {
                    len--;
                    i = 0;
                }
                if (len == 1) break;
            }
            return arr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class SimpleF
    {
        public static bool HappyG(string str)
        {
            string str1 = "gg";
            bool result = true;
            while (true) 
            {
                int indexOfChar = str.IndexOf(str1);
                if (indexOfChar != -1)
                {
                    str = str.Remove(indexOfChar, 2);
                }
                else { break; }
            }
            foreach (char item in str) 
            {
                if (item == 'g')
                    result = false;
            }
            return result;
        }
    }
}

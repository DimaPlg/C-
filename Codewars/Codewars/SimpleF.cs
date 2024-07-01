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
            int res = 1;
            int indexOfChar = 0;
            int r = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'g' && str[i + 1] == 'g')
                {
                    res++;
                }
                else if (str[i] == 'g' && str[i + 1] != 'g')
                {
                    str = str.Remove(i - res, res);
                    res = 1;
                }

            }

            if ((indexOfChar != -1))
                return false;
            else
                return true;
        }
    }
}

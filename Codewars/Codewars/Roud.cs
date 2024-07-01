using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class Roud
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            bool res = false;
            if (distanceToPump/mpg <= fuelLeft)
                res = true;
            else res = false;
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Helper
{
    public class CaculatorHelper
    {
        public static double GetMaxValue(double a, double b)
        {
            return a > b ? a : b;
        }
        public static double GetMaxValue(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}

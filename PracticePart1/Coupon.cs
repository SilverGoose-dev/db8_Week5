using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePart1
{
    public class Coupon
    {
        public static int GetSign(int num)
        {
            if (num < 0)
            {
                return -1;
            }
            else if (num > 0)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        public static bool isRangeVersion1(int num)
        {
            return false;
        }

        public static bool isRangeVersion2(int num)
        {
            return false;
        }

        public static decimal CalculateCoupon(decimal purchase)
        {
            if (purchase < 10m)
            {
                return 0;
            }
            else if (purchase <= 19.99m)
            {
                return 2m;
            }
            else 
            {
                return 3m;
            }
        }
    }
}

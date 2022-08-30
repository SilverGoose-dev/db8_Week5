using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReview
{
    public  class Misc
    {
        public static bool CheckRange(int x)
        {
            //Return tru if number is in range of 10-20 inclusive
            //Else it will return false. 

            //Test: 9, 10, 15, 20, 21
            if (x >= 10 && x <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Let's write a method that takes and int
        //and returns:
        //      -1 if the integer is negative
        //       0 if the integer is 0
        //       1 if the integer is positive 
        // What shouls we test?
        // -2, -1, 0 1, 2 these numbers will cover all of the test parameters 

        public static int PosNeg(int x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}

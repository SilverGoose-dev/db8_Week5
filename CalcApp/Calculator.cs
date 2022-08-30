using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    public class Calculator
    {
        public int Number { get; set; }

        public Calculator(int number)
        {
            Number = number;
        }


        public int FindFactorial()
        {
            // To find factorial

            //Start with the numner

            int result = Number;
            for (int next = Number -1; next >= 1; next--)
            {
                result = result * next;
            }
            return result;
        }

        public List<int> FindFactors()
        {
            List<int> result = new List<int>();
            return result;
        }
    }
}

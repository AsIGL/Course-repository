using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFunctions
{
    public static class SwapValues
    {
        public static void SwapFunction(ref int firstValue, ref int secondValue)
        {
            int temp = secondValue;
            secondValue = firstValue;
            firstValue = temp;
        }
    }
}

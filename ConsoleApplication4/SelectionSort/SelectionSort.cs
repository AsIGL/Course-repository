using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SelectionSort
{
    public static class SelectionSort
    {
        static int minimumValueIndex;
        static int minimumValue;

        public static void SelectionSortAlgo(int[] passedArray)
        {
            for (int i = 0; i < passedArray.Length; i++)
            {
                minimumValueIndex = i;
                minimumValue = passedArray[minimumValueIndex];

                for (int n = i+1; n < passedArray.Length; n++)
                {
                    if(passedArray[n] < minimumValue)
                    {
                        minimumValueIndex = n;
                        minimumValue = passedArray[n];                        
                    }
                }

                if (passedArray[i] != minimumValue)
                {
                    AdditionalFunctions.SwapValues.SwapFunction(ref passedArray[minimumValueIndex], ref passedArray[i]);              
                }
                AdditionalFunctions.PrintArray.Printing(passedArray);                
            }
        }
    }
}

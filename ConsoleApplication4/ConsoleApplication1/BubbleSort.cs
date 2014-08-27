using System;


namespace BubbleSort
{
    public class BubbleSort
    {
        public static void BubbleSortAlgo(int[] ListOfNumbers)
        {
            int LengthOfAnArray = ListOfNumbers.Length;

            for (int n = 0; n < LengthOfAnArray; n++)
            {
                Console.WriteLine("New ");
                for (int i = 1; i < (ListOfNumbers.Length); i++)
                {
                    CompareValues.CompareTwoValues(ref ListOfNumbers[i - 1], ref ListOfNumbers[i]);

                    AdditionalFunctions.PrintArray.Printing(ListOfNumbers);
                    
                }
            }

        }

        public class CompareValues
        {
            public static void CompareTwoValues(ref int firstValue, ref int secondValue)
            {
                if (firstValue > secondValue)
                {
                    AdditionalFunctions.SwapValues.SwapFunction(ref firstValue, ref secondValue);                    
                }      
            }
        }      

    }


}

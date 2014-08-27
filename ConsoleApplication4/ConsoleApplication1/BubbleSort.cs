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
                    if (ListOfNumbers[i - 1] > ListOfNumbers[i])
                    {
                        int temp = ListOfNumbers[i];
                        ListOfNumbers[i] = ListOfNumbers[i - 1];
                        ListOfNumbers[i - 1] = temp;
                    }
                    PrintArray.Printing(ListOfNumbers);
                }
            }

        }



        public class PrintArray
        {
            public static void Printing(int[] printArrayIs)
            {

                Console.Write(" Array is: ");

                foreach (var item in printArrayIs)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine(" ");
            }
        }
    }


}

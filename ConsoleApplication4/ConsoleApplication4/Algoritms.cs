using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class AlgorithmsTest
    {
        static int[] TestArray = {68,10,50,17,12 };
        static int[] TestArray1 = { 68, 10, 50, 17, 12 };
        static int[] RandomNumberArray = new int[100] ;

        static void Main(string[] args)
        {

            AdditionalFunctions.PrintArray.Printing(TestArray);         
            BubbleSort.BubbleSort.BubbleSortAlgo(TestArray);

            AdditionalFunctions.PrintArray.Printing(TestArray1);   
            SelectionSort.SelectionSort.SelectionSortAlgo(TestArray1);
            AdditionalFunctions.PrintArray.Printing(TestArray1);   

            AdditionalFunctions.RandomNumberGenerator.RandomArraygenerator(ref RandomNumberArray);

            AdditionalFunctions.PrintArray.Printing(RandomNumberArray);
            SelectionSort.SelectionSort.SelectionSortAlgo(RandomNumberArray);
            AdditionalFunctions.PrintArray.Printing(RandomNumberArray);

            //BubbleSort.BubbleSort.BubbleSortAlgo(RandomNumberArray);
            //AdditionalFunctions.PrintArray.Printing(RandomNumberArray);



            Console.WriteLine(" Algo done ");
        }
    }
    
    

    
}

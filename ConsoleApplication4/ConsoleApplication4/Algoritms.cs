using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class AlgorithmsTest
    {
        static int[] TestArray = {68,10,50,17 };
        static int[] RandomNumberArray = new int[100] ;

        static void Main(string[] args)
        {
           

            //BubbleSort.BubbleSort.PrintArray.Printing(TestArray);
            //BubbleSort.BubbleSort.BubbleSortAlgo(TestArray);

            RandomNumberGenerator.RandomArraygenerator(ref RandomNumberArray);

            BubbleSort.BubbleSort.BubbleSortAlgo(RandomNumberArray);
            BubbleSort.BubbleSort.PrintArray.Printing(RandomNumberArray);                        
            Console.WriteLine(" Algo done ");
        }
    }
    
    

    public static class RandomNumberGenerator
    {  
        public static void RandomArraygenerator(ref int[] RandomArray)
        {
            Random rnd = new Random();           
            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = rnd.Next(1, 101);               
            }
        }
    }
}

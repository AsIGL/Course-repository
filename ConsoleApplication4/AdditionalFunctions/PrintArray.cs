using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFunctions
{
    public class PrintArray
    {
        public static void Printing(int[] printArrayIs)
        {
            Console.WriteLine(); 
            Console.Write(" Array is: ");

            foreach (var item in printArrayIs)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine(" ");
        }
    }
}

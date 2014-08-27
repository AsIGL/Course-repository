using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFunctions
{
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

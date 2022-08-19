using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Arrays.Easy
{
    public class TwoNmbrSum
    {
        public void Run()
        {

            int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 10;

            //int[] array = new int[] { 4, 6 };
            //int targetSum = 10;

            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int targetSum = 17;

            //int[] array = new int[] { -21, 301, 12, 4, 65, 56, 210, 356, 9, -47 };
            //int targetSum = 164;

            //int[] array = new int[] { 14 };
            //int targetSum = 15;

            Console.WriteLine($"{TwoNumberSum(array, targetSum)}");
        }
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Write your code here.

            ////Simple Iteration Method
            //for (int i = 0; i < array.Count() - 1; i++ )
            //{
            //    //int j is for comparing with the next item in array
            //    int j = i + 1;
            //    int numToFind = targetSum - array[i];
            //    for (int k = j; k < array.Count(); k++ )
            //    {
            //        Console.WriteLine($"{array[i]}, {array[k]}");
            //    if ( array[k] == numToFind )
            //        {
            //        Console.WriteLine($"Accepted: {array[i]} + {array[k]} = {targetSum}");
            //        return new int[] { array[i], array[k] };
            //        }
            //    }
            //}

            // Hashset Implementation **Hashsets are not ordered
            HashSet<int> hashSet = new HashSet<int>(array);
            foreach (int item in array)
            {
                hashSet.Remove(item);
                int numToFind = targetSum - item;
                if ( hashSet.Contains(numToFind))
                {
                    Console.WriteLine($"{ item }, { numToFind }");
                    return new int[] { item, numToFind };
                }
            }

            return new int[0];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Arrays.Easy
{
    public class SortSqArray
    {
        public void Run()
        {
            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] array = new int[] { -2, -1 };

            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine($"{SortedSquaredArray(array)}");
        }
        public int[] SortedSquaredArray(int[] array)
        {
            // Write your code here.

            //using List
            //List<int> sortedArr = new List<int>();
            //foreach (int i in array)
            //{
            //    int squaredNum = i * i;
            //    if (sortedArr.Count == 0)
            //    {
            //        sortedArr.Add(squaredNum);
            //    }
            //    else
            //    {
            //        for ( int j = sortedArr.Count - 1; j >= 0; j-- )
            //        {
            //            if ( sortedArr[j] < squaredNum )
            //            {
            //                sortedArr.Insert(j + 1, squaredNum);
            //                break;
            //            }
            //            else if (j == 0)
            //            {
            //                sortedArr.Insert(j, squaredNum);
            //            }
            //        }
            //    }
            //}
            //return sortedArr.ToArray();

            //using only Arrays
            int[] sortedArr = new int[array.Length];
            int smlIdx = 0;
            int lgIdx = array.Length - 1;
            for ( int i = array.Length - 1; i >= 0; i-- )
            {
                int smlInt = array[smlIdx];
                int lgInt = array[lgIdx];
                if ( Math.Abs(smlInt) > Math.Abs(lgInt) )
                {
                    sortedArr[i] = smlInt * smlInt;
                    smlIdx++;
                }
                else
                {
                    sortedArr[i] = lgInt * lgInt;
                    lgIdx--;
                }
            }

            return sortedArr;
        }

    }
}

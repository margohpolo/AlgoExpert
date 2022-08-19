using System;
using System.Collections.Generic;

public class ValidateSubsequence
{

    public void Run()
    {
        //List<int> array = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
        //List<int> sequence = new List<int>() { 1, 6, -1, 10 };

        //List<int> array = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
        //List<int> sequence = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };

        List<int> array = new List<int>() { 1, 1, 1, 1, 1 };
        List<int> sequence = new List<int>() { 1, 1, 1 };

        Console.WriteLine($"{IsValidSubsequence(array, sequence)}");
    }

    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        // Write your code here.
        for ( int i = 0; i < array.Count; i++ )
        {
            if ( array[i] == sequence[0] )
            {
                sequence.RemoveAt(0);
                //Console.WriteLine($"{i}, {sequence.Count}");
            }
            if ( sequence.Count == 0 )
            {
                return true;
            }
        }

        return false;
    }
}

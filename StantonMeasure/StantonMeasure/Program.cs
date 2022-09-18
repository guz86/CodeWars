using System;

namespace StantonMeasure
{
    // The Stanton measure of an array is computed as follows: count the number of occurences
    // for value 1 in the array. Let this count be n. The Stanton measure is the number of
    // times that n appears in the array.
    //     Write a function which takes an integer array and returns its Stanton measure.
    //     Examples
    //     The Stanton measure of [1, 4, 3, 2, 1, 2, 3, 2] is 3, because 1 occurs 2 times
    // in the array and 2 occurs 3 times.
    //     The Stanton measure of [1, 4, 1, 2, 11, 2, 3, 1] is 1, because 1 occurs 3 times
    // in the array and 3 occurs 1 time.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 4, 1, 2, 11, 2, 3, 1};
            Console.WriteLine(StantonMeasure(arr));
        }
    
        public static int StantonMeasure(int[] arr)
        {
            int countOne = 0;
            int stantonMeasure = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1) countOne++;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == countOne) stantonMeasure++;
            }
            return stantonMeasure;
        }
        
        // public static int StantonMeasure(int[] arr) => arr.Count(s => s == arr.Count(i => i == 1));
    }
}
using System;

namespace CalculateAverage
{
    class Program
    {
        // Write a function which calculates the average of the numbers in a given list.
        // Note: Empty arrays should return 0.

        static void Main(string[] args)
        {
            double[] array = {17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16};
            Console.WriteLine(FindAverage(array));
        }

        private static double FindAverage(double[] array)
        {
            double avarage = 0;
            foreach (var element in array)
            {
                avarage += element;
            }

            if (array.Length != 0) return avarage / array.Length;

            return 0;
        }

        // return array.Length == 0 ? 0 : array.Average();
    }
}
using System;

namespace SortAndStar
{
    class Program
    {
        // You will be given a vector of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.
        //The returned value must be a string, and have "***" between each of its letters.
        //You should not remove or add elements from/to the array.
        // Assert.AreEqual("b***i***t***c***o***i***n", Kata.TwoSort(new [] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps"}));
        static void Main(string[] args)
        {
            string[] testStringArray = { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" };
            Console.WriteLine(SortStar(testStringArray));
        }
        static string SortStar(string[] array)
        {
           
            char startString = array[0][0];
            int elementArray = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                // char next = array[i + 1][0];
                if (startString - array[i + 1][0] >= 1)
                    {
                     startString = array[i + 1][0];
                    elementArray = i + 1;
                    }

            }
            // return startString;

            return array[elementArray];
        }
    }
}

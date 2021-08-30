using System;

namespace ReversedWords
{
    class Program
    {
            // Complete the solution so that it reverses all of the words within the string passed in.
            //Example:
            //"The greatest victory is that which requires no battle" --> "battle no requires which that is victory greatest The"
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("yoda doesn't speak like this"));
        }
        public static string ReverseWords(string str)
        {
            string[] myArray = str.Split(' ');
            string resultArray = string.Empty;

            for (int i = myArray.Length-1; i >= 0; i--)
            {
                resultArray += myArray[i]+" ";
            }
            resultArray = resultArray.Trim();
            return resultArray;
        }
    }
}

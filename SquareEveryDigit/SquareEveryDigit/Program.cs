using System;

namespace SquareEveryDigit
{
    class Program
    {
        // Welcome. In this kata, you are asked to square every digit of a number and concatenate them.
        // For example, if we run 9119 through the function, 811181 will come out, because 9 2 is 81 and 1 2 is 1.
        // Note: The function accepts an integer and returns an integer
        static void Main(string[] args)
        {
            int n = 9119;
            Console.WriteLine(SquareDigits(n));
        }
        public static int SquareDigits(int n)
        {
            char[] arrayChars = n.ToString().ToCharArray();
            string str = "";
            
            for (int i = 0; i < arrayChars.Length; i++)
            {
                int temp = Convert.ToInt32(arrayChars[i].ToString());
                str += (temp * temp).ToString();
            }
            
            return Convert.ToInt32(str);
        }
        
        
        // public static int SquareDigits(int n)
        // {
        //     string output = "";
        //     foreach (char c in n.ToString())
        //     {
        //         int square = int.Parse(c.ToString());
        //         output += (square * square);
        //     }
        //     return int.Parse(output);
        // }
        
        // return int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));
    }
}
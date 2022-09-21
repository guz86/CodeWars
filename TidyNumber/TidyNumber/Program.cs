using System;

namespace TidyNumber
{
    class Program
    {
        // A Tidy number is a number whose digits are in non-decreasing order.
        // Given a number, Find if it is Tidy or not. Number passed is always Positive. Return the result as a Boolean
        
        static void Main(string[] args)
        {
            int n = 123456;
            Console.WriteLine(TidyNumber(n));
        }
        public static bool TidyNumber(int n)
        {
            bool result = true;
            char[] arr = n.ToString().ToCharArray();
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (Convert.ToInt32(arr[i]) > Convert.ToInt32(arr[i+1]))
                {
                    result = false;
                    break;
                }
            }
           
            return result; 
        }
        
        // public static bool TidyNumber(int n) => $"{n}" == string.Concat($"{n}".OrderBy(c => c));
        // public static bool TidyNumber(int n) => n.ToString().SequenceEqual(n.ToString().OrderBy(x => x));
        
        // public static bool TidyNumber(int n)
        // {
        //     return n.ToString() == String.Concat(n.ToString().OrderBy(c => c));
        // }
    }
}
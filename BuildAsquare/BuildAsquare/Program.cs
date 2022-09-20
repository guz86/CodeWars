using System;

namespace BuildAsquare
{
    class Program
    {
        // I will give you an integer. Give me back a shape that is as long and wide as the integer. The integer will be a whole number between 1 and 50.
        // Example
        //     n = 3, so I expect a 3x3 square back just like below as a string:
        // +++
        // +++
        // +++
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(GenerateShape(n));
        }
        public static string GenerateShape(int n)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    str += "+";
                }
                if(i != n - 1) str += "\n";
            }
            
            return str;
        }
        
        // public static string GenerateShape(int n) => string.Join("\n", Enumerable.Repeat(new string('+', n), n));
        
        
        //   public static string GenerateShape(int n)
        // {
        //     return string.Join("\n", Enumerable.Repeat("".PadLeft(n, '+'), n));
        // }
        
        
        /*public static string GenerateShape(int n)
        { 
            string[] tempAns = new string[n];
    
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    tempAns[i] += "+";
                }
            }
    
            return string.Join("\n", tempAns);
        }*/
    }
}
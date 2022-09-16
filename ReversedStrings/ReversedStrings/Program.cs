using System;

namespace ReversedStrings
{
    /*
     Complete the solution so that it reverses the string passed into it.
    'world'  =>  'dlrow'
    */
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello  sdas  !df";
            Console.WriteLine(Solution(str));
        }
        public static string Solution(string str)
        {
            string temoStr = "";
            
            /*for (int i = 0; i < str.Length; i++)
            {
                temoStr += str[str.Length - 1 - i];
            }*/

            for (int i = str.Length; i > 0; i--)
            {
                temoStr += str[i-1];
            }
            
            return temoStr;
            
            
            //string.Concat(str.Reverse()); 
    
            //string.Join("",str.Reverse());   
    
            //char[] newstr = str.ToCharArray();
            //Array.Reverse(newstr);
            //return new String(newstr);
        }
    }
}
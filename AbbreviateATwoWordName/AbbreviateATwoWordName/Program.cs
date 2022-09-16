using System;

namespace AbbreviateATwoWordName
{
    /*
     Write a function to convert a name into initials.
    This kata strictly takes two words with one space in between them.
    The output should be two capital letters with a dot separating them.
    It should look like this:
    Sam Harris => S.H
    */
    class Program
    {
        static void Main(string[] args)
        {
            string name = "patrick feeney";
            Console.WriteLine(AbbrevName(name));
        }
        
        public static string AbbrevName(string name)
        {
            string[] words = name.Split(" ");
            return $"{words[0][0]}.{words[1][0]}".ToUpper();
            
            //return $"{name[0]}.{name[name.IndexOf(' ') + 1]}".ToUpper();
        }

    }
}
using System;

/*
    Дана строка, найти самый часто встречающийся в ней символ. 
    Если несколько символов встречаются одинаково часто, то можно вывести любой.
*/

namespace MostDuplicateCharacter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "ababaaabaabbbbabaabaa";
            Console.WriteLine(MostDuplicateChar(str));
        }

        private static string MostDuplicateChar(string str)
        {
            return str;
        }
    }
}
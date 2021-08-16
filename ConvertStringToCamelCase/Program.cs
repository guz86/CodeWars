using System;

/*
            Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).

            Examples
            "the-stealth-warrior" gets converted to "theStealthWarrior"
            "The_Stealth_Warrior" gets converted to "TheStealthWarrior" 
*/

namespace ConvertStringToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-stealth-warrior"));
            Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));
        }
        public static string ToCamelCase(string str)
        {
            string tempString = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '-')
                {
                    tempString += str[i + 1].ToString().ToUpper();
                    i++;
                }
                else if (str[i] == '_')
                {
                    tempString += str[i + 1].ToString().ToUpper();
                    i++;
                }
                else
                {
                    tempString += str[i];
                }


            }
         
            return tempString;
        }
    }
}

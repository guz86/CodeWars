using System;
/*
    Дана строка, найти самый часто встречающийся в ней символ. 
    Если несколько символов встречаются одинаково часто, то можно вывести любой.
*/
namespace YAP_FindMostDuplicateCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abababvbvvvvv";
            Console.WriteLine(MostDuplicateChar(str));
        }
        
        private static string MostDuplicateChar(string str)
        {
            int symbolCount = 0;
            int tempSymbol = 0;
            char symbol = ' ';
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        tempSymbol++;
                    }
                }
                
                if (symbolCount < tempSymbol)
                {
                    symbolCount = tempSymbol;
                    symbol = str[i];
                }
                
                tempSymbol = 0;
            }

            return result = symbolCount.ToString() + " " + symbol;
        }
    }
}
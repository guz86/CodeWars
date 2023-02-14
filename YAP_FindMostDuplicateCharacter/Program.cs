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
            int tmpLetterCount;
            string letter = "";
            for (int i = 0; i < str.Length; i++)
            {
                tmpLetterCount = 0;
                
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        tmpLetterCount++;
                    }
                }
                
                if (tmpLetterCount > symbolCount)
                {
                    //symbolCount = tempSymbol;
                    letter = str[i].ToString();
                }
            }

            return letter;
            //return  $"{symbol} {symbolCount.ToString()}";
        }
    }
}
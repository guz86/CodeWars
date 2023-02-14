using System;
using System.Linq;

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
            string str = "aaaasssssssddddddddddddsssssssssssssaaaaaaa";
            
            //string str = Console.ReadLine();
            // 1
            Console.WriteLine(MostDuplicateChar(str));
            
            // 2
            //string answer = new String(str.Distinct().ToArray());
            Console.WriteLine(DistinctMostDuplicateChar(str));
            
        }

        // решение 1 - сложность: n в квадрате

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
                    symbolCount = tmpLetterCount;
                    letter = str[i].ToString();
                }
            }

            return letter;
            //return  $"{symbol} {symbolCount.ToString()}";
        }

        // решение 2 - сложность: Н*к - к-количество букв
        // вариант пробежаться через алфавит?
        // вариант через линку с Distinct()

        private static string DistinctMostDuplicateChar(string str)
        {
            int symbolCount = 0;
            int tmpLetterCount;
            string letter = "";
            string distinctStr = new String(str.Distinct().ToArray());

            foreach (var stringChar in distinctStr)
            {
                tmpLetterCount = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (stringChar == str[j])
                    {
                        tmpLetterCount++;
                    }
                }

                if (tmpLetterCount > symbolCount)
                {
                    symbolCount = tmpLetterCount;
                    letter = stringChar.ToString();
                }
            }

            return letter;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

/*
    Дана строка, найти самый часто встречающийся в ней символ. 
    Если несколько символов встречаются одинаково часто, то можно вывести любой.
    https://www.youtube.com/watch?v=QLhqYNsPIVo
*/
namespace YAP_FindMostDuplicateCharacter
{
    class Program
    {
        static void Main(string[] args)
        {  
            //string str = Console.ReadLine();
            // 1
            Console.WriteLine(MostDuplicateChar("aaaasssssssddddddffffssdddddddddddsssaaaaaaa"));
            Console.WriteLine(MostDuplicateChar("aab"));
            Console.WriteLine(MostDuplicateChar("abb"));
            Console.WriteLine(MostDuplicateChar("bab"));
            Console.WriteLine(MostDuplicateChar("aba"));
            Console.WriteLine(MostDuplicateChar("a"));
            Console.WriteLine(MostDuplicateChar(""));
            Console.WriteLine("");
            // 2
            //string answer = new String(str.Distinct().ToArray());
            Console.WriteLine(DistinctMostDuplicateChar("aaaasssssssddddddffffssdddddddddddsssaaaaaaa"));
            Console.WriteLine(DistinctMostDuplicateChar("aab"));
            Console.WriteLine(DistinctMostDuplicateChar("abb"));
            Console.WriteLine(DistinctMostDuplicateChar("bab"));
            Console.WriteLine(DistinctMostDuplicateChar("aba"));
            Console.WriteLine(DistinctMostDuplicateChar("a"));
            Console.WriteLine(DistinctMostDuplicateChar(""));
            Console.WriteLine("");
            // 3
            Console.WriteLine(DictionaryMostDuplicateChar("aaaasssssssddddddffffssdddddddddddsssaaaaaaa"));
            Console.WriteLine(DictionaryMostDuplicateChar("aab"));
            Console.WriteLine(DictionaryMostDuplicateChar("abb"));
            Console.WriteLine(DictionaryMostDuplicateChar("bab"));
            Console.WriteLine(DictionaryMostDuplicateChar("aba"));
            Console.WriteLine(DictionaryMostDuplicateChar("a"));
            Console.WriteLine(DictionaryMostDuplicateChar(""));
        }

        // решение 1 - сложность: n в квадрате   0(Н2)
        //( по памяти 1 строки с Н элементами)

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
                    if (str[i] == str[j]) tmpLetterCount++;
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

        // решение 2 - сложность: Н*к - к-количество букв 0(Н*к)
        // вариант пробежаться через алфавит?
        // вариант через линку с Distinct()
        //( по памяти 2 строки с Н и К элементами)

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
                    if (stringChar == str[j]) tmpLetterCount++;
                }

                if (tmpLetterCount > symbolCount)
                {
                    symbolCount = tmpLetterCount;
                    letter = stringChar.ToString();
                }
            }

            return letter;
        }
        
        // решение 3 через словарь - сложность: Н+к - к-количество ключей в словаре или просто 0(Н)
        //( саму строку в памяти можно не хранить только словарь с К элементами)
        
        private static char DictionaryMostDuplicateChar(string str)
        {
            var letters = new Dictionary<char, int>();
            
            foreach (var letterString in str)
            {
                if (!letters.ContainsKey(letterString))
                {
                    letters[letterString] = 0;
                }
                else
                {
                    letters[letterString] += 1;
                }
            }

            //var letter = (from d in letters select d.Key).Max();
            char letter = ' '; // char в C# - это value type, он не может иметь пустое значение,
            var letterCount = 0;
            
            foreach (var keyValuePair in letters)
            {
                if (keyValuePair.Value >= letterCount) // чтобы при тестах учитывалась строка из 1 чара >=
                {
                    letterCount = keyValuePair.Value;
                    letter = keyValuePair.Key;
                }
            }
            
            return letter;
        }
    } 
}
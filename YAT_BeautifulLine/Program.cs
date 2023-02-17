using System;
using System.Collections.Generic;

namespace YAT_BeautifulLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.TryParse(Console.ReadLine(), out int count);
            //string line = Console.ReadLine();


            //int count = 2;
            //string line = "abcaz";

            //Console.WriteLine(BeautifulLine(count, line));
            //  Console.WriteLine(BeautifulLine(2, "abcaz"));
            //  Console.WriteLine(BeautifulLine(2, "helto"));
            // Console.WriteLine(BeautifulLine(3, "abvcaz"));
            // Console.WriteLine(BeautifulLine(4, "abvcfaz"));
            // Console.WriteLine(BeautifulLine(4, "babvcfaz"));
            Console.WriteLine(CharacterReplacement(4, "abcazd"));
        }

        private static int BeautifulLine(int count, string line)
        {
            int result = 0;

            char lastChar;
            //char findChar = ' ';
            int countChar;
            bool notLine = true;

            for (int i = 0; i < line.Length; i++)
            {
                countChar = 0;
                lastChar = line[i];

                for (var j = i + 1; j < line.Length; j++)
                {
                    if (line[j] != lastChar)
                    {
                        countChar++;
                    }
                    else if (countChar == count)
                    {
                        //findChar = lastChar;
                        result = 2 + count;
                        notLine = false;
                    }
                }
            }

            //return findChar;
            if (notLine) result = 1 + count;

            return result;
        }


        // правильное решение

        public static int CharacterReplacement( int k, string s)
        {
            IDictionary<int, int> map = new Dictionary<int, int>();
            int left = 0;
            int result = 0;
            int max = 0;
            for (int right = 0; right < s.Length; right++)
            {
                if (!map.ContainsKey(s[right]))
                {
                    map.Add(s[right], 1);
                }
                else
                {
                    map[s[right]]++;
                }

                max = Math.Max(map[s[right]], max);
                while ((right - left + 1) - max > k)
                {
                    map[s[left]]--;
                    left = left + 1;
                }

                result = Math.Max(right - left + 1, result);
            }

            return result;
        }
    }
}
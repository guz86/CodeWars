using System;

namespace FindTheMissingLetter
{
    class Program
    {
        public static char FindMissingLetter(char[] array)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };



            int start = -1;
            for (int i = 0; i < letters.Length; i++)
            {
                if (Char.ToUpper(array[0]) == Char.ToUpper(letters[i]))
                {
                    start = i;
                    break;
                }
            }

            for (int i = start, j = 0; i < letters.Length; i++, j++)
            {

                if (Char.ToUpper(array[j]) != Char.ToUpper(letters[i]) && char.IsUpper(array[j]) )
                {
                    return Char.ToUpper(letters[i]);
                }
                if (Char.ToUpper(array[j]) != Char.ToUpper(letters[i]))
                {
                    return letters[i];
                }
            }

            return ' ';
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Console.WriteLine(FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }
    }
}

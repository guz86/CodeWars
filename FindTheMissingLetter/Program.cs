using System;

namespace FindTheMissingLetter
{
    class Program
    {
        public static char FindMissingLetter(char[] array)
        {
            // char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            // English alphabet with 26 letters!
            char[] letters = new char[26];
            sbyte k = 0;

            for (char c = 'a'; c <= 'z'; c++)
            {
                letters[k] = c;
                k++;
            }


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


            //ASCII code 65 = A(Capital letter A )
            //ASCII code 97 = a(Lowercase letter a , minuscule a)

        public static char FindMissingLetter2(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] > 1)
                {
                    return (char)(array[i] + 1);
                }
            }

            return ' ';
        }

        static void Main(string[] args)
        {

            Console.WriteLine(FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Console.WriteLine(FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
            Console.WriteLine(FindMissingLetter2(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Console.WriteLine(FindMissingLetter2(new[] { 'O', 'Q', 'R', 'S' }));
        }
    }
}

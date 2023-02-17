using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace YAP_LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinearSearch");
            Console.WriteLine(LinearSearch(Sequence("121"), 2));
            Console.WriteLine(LinearSearch(Sequence("213"), 2));
            Console.WriteLine(LinearSearch(Sequence("132"), 2));
            Console.WriteLine(LinearSearch(Sequence("133f"), 2));
            Console.WriteLine(LinearSearch(Sequence("2"), 2));
            Console.WriteLine(LinearSearch(Sequence(""), 2));

            Console.WriteLine("ReLinearSearch");
            Console.WriteLine(ReLinearSearch(Sequence("121"), 2));
            Console.WriteLine(ReLinearSearch(Sequence("213"), 2));
            Console.WriteLine(ReLinearSearch(Sequence("132"), 2));
            Console.WriteLine(ReLinearSearch(Sequence("133f"), 2));
            Console.WriteLine(ReLinearSearch(Sequence("2"), 2));
            Console.WriteLine(ReLinearSearch(Sequence(""), 2));

            Console.WriteLine("EqualsLinearSearch");
            Console.WriteLine(EqualsLinearSearch(Sequence("121"), 2));
            Console.WriteLine(EqualsLinearSearch(Sequence("213"), 2));
            Console.WriteLine(EqualsLinearSearch(Sequence("132"), 2));
            Console.WriteLine(EqualsLinearSearch(Sequence("133f"), 2));
            Console.WriteLine(EqualsLinearSearch(Sequence("2"), 2));
            Console.WriteLine(EqualsLinearSearch(Sequence(""), 2));

            Console.WriteLine("MinLinearSearch");
            Console.WriteLine(MinLinearSearch(Sequence("1221"), 2));
            Console.WriteLine(MinLinearSearch(Sequence("213"), 2));
            Console.WriteLine(MinLinearSearch(Sequence("1322"), 2));
            Console.WriteLine(MinLinearSearch(Sequence("133f"), 2));
            Console.WriteLine(MinLinearSearch(Sequence("22"), 2));
            Console.WriteLine(MinLinearSearch(Sequence(""), 2));

            Console.WriteLine("LastLinearSearch");
            Console.WriteLine(LastLinearSearch(Sequence("1221"), 2));
            Console.WriteLine(LastLinearSearch(Sequence("213"), 2));
            Console.WriteLine(LastLinearSearch(Sequence("1322"), 2));
            Console.WriteLine(LastLinearSearch(Sequence("133f"), 2));
            Console.WriteLine(LastLinearSearch(Sequence("22"), 2));
            Console.WriteLine(LastLinearSearch(Sequence(""), 2));

            // реализация методов в шапе
            Console.WriteLine("реализация методов arr 3212");
            int[] arr = Sequence("3212");
            Console.WriteLine($"Индекс элемента со значением 1 равен {Array.IndexOf(arr, 1)}");
            Console.WriteLine($"Минимальный элемент массива: индекс {Array.IndexOf(arr, arr.Min())}");
            Console.WriteLine($"Максимальный элемент массива: индекс {Array.IndexOf(arr, arr.Max())}");


            Console.WriteLine("TwoMaxLinearSearch");
            TwoMaxLinearSearch(Sequence("3214")); // [4,3]

            Console.WriteLine("MinEvenLinearSearch");
            Console.WriteLine(MinEvenLinearSearch(Sequence("124")));
            Console.WriteLine(MinEvenLinearSearch(Sequence("214")));
            Console.WriteLine(MinEvenLinearSearch(Sequence("432")));
            Console.WriteLine(MinEvenLinearSearch(Sequence("133f"))); // 0 из за символа f
            Console.WriteLine(MinEvenLinearSearch(Sequence("44")));
            Console.WriteLine(MinEvenLinearSearch(Sequence("1")));
            Console.WriteLine(MinEvenLinearSearch(Sequence("")));

            Console.WriteLine("ShortWordsLinearSearch");
            string[] stringArr = {"a", "bb", "vvv", "a", "d", "ss", "qq", "q"};
            Console.WriteLine(ShortWordsLinearSearch(stringArr));

            Console.WriteLine("RLELinearSearch");
            string stringAZ = "AAAABBBCCXYZDDDDEEEFFFAAAAAABBBBBBBBBBBBBBBBBBBBBBBBBBBB";
            Console.WriteLine(RLELinearSearch(stringAZ));
            Console.WriteLine(RLELinearSearch(""));
            Console.WriteLine(RLELinearSearch("AAAABBBя"));
            Console.WriteLine(RLELinearSearch("AAAABBBz"));
        }

        private static int[] Sequence(string elements)
        {
            int[] arr = new int[elements.Length];
            for (var i = 0; i < elements.Length; i++)
            {
                int.TryParse(elements[i].ToString(), out int temp);
                arr[i] = temp;
            }

            return arr;
        }

        // найти позицию - первое левое вхождение положительного числа Х или вывести -1
        // 1
        private static int LinearSearch(int[] elements, int element)
        {
            int result = -1;
            for (int i = 0; i < elements.Length; i++)
            {
                if (element == elements[i] && result == -1) result = i;
            }

            return result;
        }

        // 2 позицию - c последнего элемента
        private static int ReLinearSearch(int[] elements, int element)
        {
            int result = -1;
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                if (element == elements[i]) result = i;
            }

            return result;
        }

        // 3 позицию - по значению c последнего элемента
        private static int EqualsLinearSearch(int[] elements, int element)
        {
            int result = -1;
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                if (elements[i].Equals(element)) result = i;
            }

            return result;
        }

        // найти минимальное значения массива
        private static int MinLinearSearch(int[] elements, int element)
        {
            int result = -1;

            if (elements.Length > 0) result = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i].CompareTo(result) < 0) // if elements[i] > result
                    result = elements[
                        i]; // 0 -1 1 расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки
                // лучше сохранять индекс при проверке result = i и в конце выводить элемент с нужным индексом, вместо перезаписывания переменной
            }

            return result;
        }


        // найти последнее правое вхождение положительного числа Х или вывести -1
        private static int LastLinearSearch(int[] elements, int element)
        {
            int result = -1;
            for (int i = 0; i < elements.Length; i++)
            {
                if (element == elements[i]) result = i;
            }

            return result;
        }


        // найти максимальное число в последовательности и второе по величине число (которое будет максимальным если вычеркнуть ОДНО первое)
        // 3 2 1 3  гарантированно минимум 2 элемента в последовательности

        private static int[] TwoMaxLinearSearch(int[] elements)
        {
            int max1 = elements[1] > elements[0] ? elements[1] : elements[0]; // b > a ? b : a;
            int max2 = elements[1] < elements[0] ? elements[1] : elements[0];

            for (int i = 2; i < elements.Length; i++)
            {
                if (elements[i] > max1)
                {
                    max2 = max1;
                    max1 = elements[i];
                }
                else if (elements[i] > max2)
                {
                    max2 = elements[i];
                }
            }

            return new[] {max1, max2};
        }

        // Найти минимальное четное число в последовательности или вывести -1, если такого не существует

        private static int MinEvenLinearSearch(int[] elements)
        {
            int result = -1;
            bool even = false;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] % 2 == 0 & (!even || elements[i] < result))
                {
                    result = elements[i];
                    even = true;
                }
            }

            return result;
        }


        // Дана последовательность слов. Вывести все самые короткие слова через пробел
        // требуется двойной проход, чтобы это было быстрее (1. поиск минимальной длины, 2. собираем строку)
        // не нужно пересоздавать каждый раз новую строку, поэтому нужно собирать список а потом из списка делать строку
        // "a", "bb", "vvv", "a", "d", "ss", "qq", "q"

        private static string ShortWordsLinearSearch(string[] words)
        {
            int minLen = words[0].Length;

            foreach (var word in words)
            {
                if (word.Length < minLen) minLen = word.Length;
            }

            List<string> shortWords = new List<string>();

            foreach (var word in words)
            {
                if (word.Length == minLen) shortWords.Add(word);
            }

            return String.Join((" "), shortWords.ToArray());
        }

        // RLE способ сжатия АААА в А4
        /*
         Дана строка, состоящая из букв A-Z:
         "AAAABBBCCXYZDDDDEEEFFFAAAAAABBBBBBBBBBBBBBBBBBBBBBBBBBBB"
         Нужно написать функцию RLE, которая на выходе даст строку вида:
         "A4B3C2XYZD4E3F3A6B28"
         И сгенерирует любую ошибку, если на вход пришла невалидная строка.
        
         Пояснение:
         1. если символ встречается 1 раз, он остается без изменений
         2. если символ повторяется более 1 раза, к нему добавляется количество повторений
        */

        // - Оставить уникальные буквы, посчитать их количество

        private static string RLELinearSearch(string stringAZ)
        {
            if (stringAZ.Length == 0)
            {
                return "пустая строка";
            }

            if (!Regex.IsMatch(stringAZ, "^[A-Z0-9]*$"))
            {
                return "невалидная строка";
            }

            // if (!stringAZ.All(char.IsLetterOrDigit)) {
            //     return "невалидная строка";
            // }

            // if (!stringAZ.All(c => (c >= 48 && c <= 57 || c >= 97 && c <= 122))) {
            //     return "невалидная строка";
            // }

            string lastChar = stringAZ[0].ToString();

            List<string> singleChars = new List<string>();

            int lastPos = 0;
            for (int i = 0; i < stringAZ.Length; i++)
            {
                if (stringAZ[i].ToString() != lastChar)
                {
                    string count = (i - lastPos) > 1 ? (i - lastPos).ToString() : "";  // или можно сделать отдельный счетчик который увеличивать и сбрасывать

                    singleChars.Add(lastChar + count);
                    lastPos = i;
                    lastChar = stringAZ[i].ToString();
                }
            }

            singleChars.Add(lastChar + (stringAZ.Length - lastPos));

            //return String.Join((""), singleChars.ToArray());
            return String.Concat(singleChars);
        }
    }
}
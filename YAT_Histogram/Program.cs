using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace YAT_Histogram
{
    class Program
    {
        //Вовочка ломает систему безопасности Пентагона. Для этого ему понадобилось узнать, какие символы
        //в секретных зашифрованных посланиях употребляются чаще других.
        //Для удобства изучения Вовочка хочет получить графическое представление встречаемости символов.
        //Поэтому он хочет построить гистограмму количества символов в сообщении.
        //Гистограмма — это график, в котором каждому символу, встречающемуся в сообщении хотя бы один раз,
        //соответствует столбик, высота которого пропорциональна количеству этих символов в сообщении.
        
        static void Main(string[] args)
        {
            string readText = File.ReadAllText(@"input.txt");
            Histogram(readText);
        }

        private static void Histogram(string str)
        {
            string strClear = str.Replace("\n", string.Empty).
                Replace("\r", string.Empty).
                Replace(" ", string.Empty);
            string result = "";
            var letters = new Dictionary<char, int>();

            foreach (var letterStr in strClear)
            {
                if (letters.ContainsKey(letterStr))
                {
                    letters[letterStr] += 1;
                }
                else
                {
                    letters[letterStr] = 1;
                }
            }

            var maxValue = letters.Max(letter => letter.Value);

            foreach (var letter in letters.OrderBy(letter => letter.Key))
            {
                result += $"{letter.Key}";
            }

            var max = maxValue;
 
            for (int i = 0; i < maxValue; i++)
            {
                string paintStr = "";
                foreach (var letter in letters.OrderBy(letter => letter.Key))
                {
                    if (letter.Value >= max)
                    {
                        paintStr += "#";
                    }
                    else
                    {
                        paintStr += " ";
                    }
                }

                max--;
                    //Console.WriteLine();
                    File.AppendAllText(@"output.txt", $"{paintStr}\n");
            }
            File.AppendAllText("output.txt", result);
            //Console.WriteLine(result); 
        }
    }
}
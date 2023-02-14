using System;

namespace YAP_MaximumSequence
{
    // максиум последовательности https://www.youtube.com/watch?v=QLhqYNsPIVo
    class Program
    {
        static void Main(string[] args)
        {
            // тесты - один тест одна ошибка
            Console.WriteLine(MaximumSequence("1 3 2")); // в середине
            Console.WriteLine(MaximumSequence("1 2 3")); // последний
            Console.WriteLine(MaximumSequence("3 2 1")); // первый
            Console.WriteLine(MaximumSequence("1 1 1")); // все одинаковы
            Console.WriteLine(MaximumSequence("1"));  // один элемент
            Console.WriteLine(MaximumSequence("")); // пустая строка
            Console.WriteLine(MaximumSequence("   33 22 55 2 1 ")); // пробелы с краев
            Console.WriteLine(MaximumSequence("-2 -1 -3")); // все отрицательные
        }

        private static string MaximumSequence(string sequenceDigit)
        {
            var sequence = sequenceDigit.Split(" ", StringSplitOptions.RemoveEmptyEntries); // провека пустая строка чтобы длина была 0 и пустые символы
            
            if (sequence.Length == 0) return ""; // проверка на пустоту
            
            int.TryParse(sequence[0], out int result);
            
            foreach (var element in sequence)
            {
                if (int.TryParse(element, out int intElement))
                {
                    if (intElement > result)
                    {
                        result = intElement;
                    }
                }
            }

            return result.ToString();
        }
    }
}
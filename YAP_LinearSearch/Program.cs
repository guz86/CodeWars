using System;

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
            
            Console.WriteLine("LastLinearSearch");
            
            Console.WriteLine(LastLinearSearch(Sequence("1221"), 2));
            Console.WriteLine(LastLinearSearch(Sequence("213"), 2));
            Console.WriteLine(LastLinearSearch(Sequence("1322"), 2));
            Console.WriteLine(LastLinearSearch(Sequence("133f"), 2));
            Console.WriteLine(LastLinearSearch(Sequence("22"), 2));
            Console.WriteLine(LastLinearSearch(Sequence(""), 2));
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

        // найти первое левое вхождение положительного числа Х или вывести -1
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
        
        // 2 c последнего элемента
        private static int ReLinearSearch(int[] elements, int element)
        {
            int result = -1;
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                if (element == elements[i]) result = i;
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
    }
}
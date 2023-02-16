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
            int result = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i].CompareTo(result) < 0) 
                    result = elements[i];  // 0 -1 1 расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки
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
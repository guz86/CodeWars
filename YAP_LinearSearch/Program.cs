using System;

namespace YAP_LinearSearch
{
    class Program
    {
        // найти первое левое вхождение положительного числа Х или вывести -1
        
        static void Main(string[] args)
        {
            Console.WriteLine(LinearSearch("121", 2));
            Console.WriteLine(LinearSearch("213", 2));
            Console.WriteLine(LinearSearch("132", 2));
            Console.WriteLine(LinearSearch("133f", 2));
            Console.WriteLine(LinearSearch("2", 2));
            Console.WriteLine(LinearSearch("", 2));
        }

        private static int LinearSearch(string elements, int element)
        {
            int[] arr = new int[elements.Length];
            for (var i = 0; i < elements.Length; i++)
            {
                int.TryParse(elements[i].ToString(), out int temp);
                arr[i] = temp;
            }
            
            int result = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (element == arr[i] && result == -1) result = i;
            }

            return result;
        }
    }
}
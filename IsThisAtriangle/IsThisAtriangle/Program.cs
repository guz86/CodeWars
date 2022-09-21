using System;

namespace IsThisAtriangle
{
    class Program
    {
        // Implement a function that accepts 3 integer values a, b, c.
        // The function should return true if a triangle can be built with the sides
        // of given length and false in any other case.
        // (In this case, all triangles must have surface greater than 0 to be accepted).
        
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = 1;
            Console.WriteLine(IsTriangle(a, b, c));
        }
        // сумма длин 2х сторон больше 3ей
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a+b > c &&
                a+c > b &&
                b+c > a 
                ) return true;
            else return false;
        }
        
        //return (a+b > c && b+c >a && a+c > b);
        
        // если две самых маленьких больше третей, занчит и все больше.
        // public static bool IsTriangle(int a, int b, int c)
        // {
        //     var lengths = new List<int>() {a, b, c};
        //     lengths.Sort();
        //     return lengths[0] + lengths[1] > lengths[2];
        // }
    }
}
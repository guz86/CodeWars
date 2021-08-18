using System;

namespace BinaryAddition
{
    class Program
    {
                //Implement a function that adds two numbers together and returns their sum in binary.The conversion can be done before, or after the addition.
                //The binary number returned should be a string.
                //Examples:
                //add_binary(1, 1) == "10" (1 + 1 = 2 in decimal or 10 in binary)
                //add_binary(5, 9) == "1110" (5 + 9 = 14 in decimal or 1110 in binary)
        public static string AddBinary(int a, int b)
        {
            int value = a + b;
            string binary = Convert.ToString(value, 2);
            return binary;

            // 
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary(5,9));
        }

    }
}

/*
    Make a function that will return a greeting statement that uses an input; 
    your program should return, "Hello, <name> how are you doing today?".

    [Make sure you type the exact thing I wrote or the program may not execute properly]
*/

namespace ReturningStrings;

public static class Kata
{
    static void Main(string[] args)
    {
        string name = "Alexey";
        Console.WriteLine(Greet(name));
    }
    
    public static string Greet(string name)
    {
        return $"Hello, {name} how are you doing today?";
    }
}
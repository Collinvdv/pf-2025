namespace Week1HelloWorld;
using System;
using System.Formats.Tar;

internal class Program
{
    private static void Main()
    {
        int n = Convert.ToInt16(Console.ReadLine());
        char c = Convert.ToChar(n);


        Console.WriteLine(Char.ToLower(c));
        Console.WriteLine(Char.ToUpper(c));
    }
}

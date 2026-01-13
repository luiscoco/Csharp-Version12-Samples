using System;
class Program
{
    static void Main()
    {
        var toStr = string (ReadOnlySpan<char> s) => s.ToString();
        Console.WriteLine(toStr("hi".AsSpan()));
    }
}

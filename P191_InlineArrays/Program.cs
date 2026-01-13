using System;
using System.Runtime.CompilerServices;
[InlineArray(4)]
public struct Buffer
{
    private int _element0;
}
class Program
{
    static void Main()
    {
        Buffer buf = default;
        for (int i = 0; i < 4; i++) buf[i] = i + 1;
        int total = 0;
        for (int i = 0; i < 4; i++) total += buf[i];
        Console.WriteLine(total);
    }
}

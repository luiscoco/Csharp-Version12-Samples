using System;
class Program
{
    static void Main()
    {
        var add = (int a, int b = 5) => a + b;
        Console.WriteLine(add(2));
        Console.WriteLine(add(2, 10));
    }
}

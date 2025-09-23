using System;
class Program
{
    static int Sum(ref readonly int a, ref readonly int b) => a + b;
    static void Main()
    {
        int x = 3, y = 4;
        Console.WriteLine(Sum(in x, in y));
    }
}

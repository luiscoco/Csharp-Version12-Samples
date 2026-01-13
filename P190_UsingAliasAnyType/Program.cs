using System;
using IntPair = (int X, int Y);
using IntMatrix = int[,,];
class Program
{
    static void Main()
    {
        IntPair p = (1, 2);
        Console.WriteLine($"{p.X},{p.Y}");
        IntMatrix m = new int[1,1,1];
        m[0,0,0] = 42;
        Console.WriteLine(m[0,0,0]);
    }
}

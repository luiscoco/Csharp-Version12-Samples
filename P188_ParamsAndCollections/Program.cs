using System;
class Program
{
    static int Sum(params int[] values)
    {
        int s = 0;
        for (int i = 0; i < values.Length; i++) s += values[i];
        return s;
    }
    static void Main()
    {
        Console.WriteLine(Sum([1,2,3]));
        int[] a = [4,5];
        Console.WriteLine(Sum([..a, 6]));
    }
}

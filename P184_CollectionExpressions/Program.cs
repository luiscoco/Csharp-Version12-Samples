using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] a = [1, 2, 3];
        List<int> list = [..a, 4, 5];
        ReadOnlySpan<int> span = [10, 20, 30];
        Console.WriteLine(string.Join(",", a));
        Console.WriteLine(string.Join(",", list));
        int sum = 0;
        for (int i = 0; i < span.Length; i++) sum += span[i];
        Console.WriteLine(sum);
    }
}

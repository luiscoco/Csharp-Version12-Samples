using System;
using System.Diagnostics.CodeAnalysis;
public static class Api
{
    [Experimental("EXP001")]
    public static void OldWay() => Console.WriteLine("Old way");
}
class Program
{
    static void Main()
    {
        Api.OldWay();
        Console.WriteLine("Check build output for EXP001 warning.");
    }
}

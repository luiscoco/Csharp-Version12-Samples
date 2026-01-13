using System;
using System.Runtime.CompilerServices;
// Preview-only illustration of interceptors attribute
#if !NET8_0_OR_GREATER
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    file sealed class InterceptsLocationAttribute : Attribute
    {
        public InterceptsLocationAttribute(string filePath, int line, int column) { }
    }
}
#endif
class Program
{
    static void Main()
    {
        Console.WriteLine("Interceptors preview illustration only.");
    }
}

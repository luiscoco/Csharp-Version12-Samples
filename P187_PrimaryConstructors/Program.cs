using System;
class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;
    public override string ToString() => $"{Name} ({Age})";
}
struct Box(int width, int height)
{
    public int Width { get; } = width;
    public int Height { get; } = height;
    public int Area => Width * Height;
}
class Program
{
    static void Main()
    {
        var p = new Person("Ana", 30);
        var b = new Box(3, 4);
        Console.WriteLine(p);
        Console.WriteLine($"Area={b.Area}");
    }
}

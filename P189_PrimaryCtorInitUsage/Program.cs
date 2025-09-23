using System;
class Base(int id)
{
    public int Id { get; } = id;
}
class Derived(int id, string tag) : Base(id)
{
    public string Tag { get; } = tag;
    public override string ToString() => $"{Id}:{Tag}";
}
class Program
{
    static void Main()
    {
        Console.WriteLine(new Derived(7, "ok"));
    }
}

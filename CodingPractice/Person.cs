using System;

public partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }
}
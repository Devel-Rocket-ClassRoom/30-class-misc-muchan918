using System;

public partial class Character
{
    private readonly string _name;
    private int _health;
    private int _level;

    public string Name => _name;
    public int Health => _health;
    public int Level => _level;

    public Character(string name)
    {
        _name = name;
        _health = 100;
        _level = 1;
    }
}
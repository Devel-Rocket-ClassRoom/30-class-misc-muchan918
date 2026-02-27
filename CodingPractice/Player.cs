using System;

public class Player
{
    public readonly string Name;
    public readonly int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }

    // 레벨업 시 새 객체 반환
    public Player LevelUp()
    {
        return new Player(Name, Level + 1);
    }
}
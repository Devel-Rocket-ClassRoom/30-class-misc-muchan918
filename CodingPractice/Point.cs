using System;

public class Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // 새 Point 객체를 반환
    public Point MoveBy(int dx, int dy)
    {
        return new Point(X + dx, Y + dy);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
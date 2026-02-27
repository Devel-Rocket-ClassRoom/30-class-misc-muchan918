using System;

public class ImmutableCircle
{
    public int Radius { get; }  // 읽기 전용

    public ImmutableCircle(int radius)
    {
        Radius = radius;
    }

    // 새 객체를 반환하는 메서드
    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }
}
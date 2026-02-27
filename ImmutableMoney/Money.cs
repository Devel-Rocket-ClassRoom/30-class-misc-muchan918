using System;

public class Money
{
    public int Gold { get; }
    public int Silver { get; }

    public Money(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }

    public Money Add(int gold, int silver)
    {
        return new Money(gold + Gold, silver + Silver);
    }

    public Money Subtract(int gold, int silver)
    {
        if (Gold > gold && Silver > silver)
            return new Money(Gold - gold, Silver - silver);
        else
            return new Money(Gold, Silver);
    }
}
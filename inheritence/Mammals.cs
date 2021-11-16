using System;

public class Mammals:Animals
{
    public Mammals()
    {
        base.MoveAbility();
        base.Reaction();
    }
    public void Birth()
    {
        Console.WriteLine("Mammals can give birth");
    }
}
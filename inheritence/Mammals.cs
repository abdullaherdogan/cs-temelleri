using System;

public class Mammals:Animals
{
    public Mammals()
    {
        base.MoveAbility();
    }
    public void Birth()
    {
        Console.WriteLine("Mammals can give birth");
    }
}
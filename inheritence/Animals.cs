using System;

public class Animals:Creatures
{
    public Animals()
    {
        base.Breath(); // kalitim alinan classin protected metodlarini kullanabilmek icin
        base.Feed();
    }
    protected void MoveAbility()
    {
        Console.WriteLine("Animals can move");
    }
    public override void Reaction()
    {
        base.Reaction();
        Console.WriteLine("Animals reacts to effect");
    }
}
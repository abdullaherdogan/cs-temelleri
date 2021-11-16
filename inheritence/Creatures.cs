using System;
public class Creatures
{
    protected void Breath()
    {
        Console.WriteLine("Creatures can breathing");
    }
    protected void Feed()
    {
        Console.WriteLine("Creatures can feeding");
    }
}
public class Plants:Creatures
{
    public Plants()
    {
        base.Breath(); // protected metodu kalitim alan classlarda kullanmak icin
        base.Feed();
    }
    public void Photosynthesis()
    {
        Console.WriteLine("Plants can Photosynthesis");
    }
}
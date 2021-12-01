using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            IGun ak47 = new Ak47();
            IGun m16 = new M16();
            IPlayer teroristPlayer = new Terorist(ak47);
            teroristPlayer.AtesEt();
        }
    }
}

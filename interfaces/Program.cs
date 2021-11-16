using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.WhichColor(Color.red));
        }
    }
}

using System;

namespace abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Civic civic = new Civic();
            Console.WriteLine(civic.WhichColor());
            Console.WriteLine(civic.WhichBrand());
        }
    }
}

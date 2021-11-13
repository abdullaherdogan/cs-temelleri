using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isminizi girin!");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin");
            string surName= Console.ReadLine();
            Console.WriteLine("isminiz "+ name+" Soyisminiz " + surName);
        }
    }
}

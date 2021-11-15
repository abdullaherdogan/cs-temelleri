using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Friday);// index of Friday

            int Temprature= 32;
            if (Temprature>(int)Weather.Normal)
            {
                Console.WriteLine("It's a little hot outside");
            }
        }
    }
}

enum Weather
{
    Cold=5,
    Normal=20,
    Hot = 29,
    RealyHot=35
}
enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
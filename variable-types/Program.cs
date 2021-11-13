using System;

namespace variable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte inegerByte = 5; //1 btye integer
            short shortNum = 5; // 2 byte
            int integerNum = 5;// 4 byte integer
            long longNum = 5; // 4byte
            float floatNum = 5; // 4 byte float
            double doubleNum = 5.5; // 8 byte 
            decimal decimalNum = 5; // 16 byte

            char character = 'c'; // one char
            string text = "some text"; // text
            bool boolean = true; // boolean
            DateTime dt = DateTime.Now; // date of now

            // convert of variables
            int num = 29;
            num.ToString(); // integer to string
            string strNum = "20";
            Convert.ToInt32(strNum);// string to int

            // date time
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy"); // date format day.month.year
            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy"); // date format as upper with /
            string dateTime3 = DateTime.Now.ToString("HH:mm"); // date format hour and minute
        }
    }
}

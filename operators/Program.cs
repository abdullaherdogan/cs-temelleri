using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 3;
            int sayi2 = 4;
            int toplam = sayi1+sayi2;
            int carpim = sayi1*sayi2;

            sayi1-= sayi2;

            sayi2/= 4;

            sayi1 = sayi1++;

            // logic operators
            bool isCompleted = true;
            bool isSuccess = false;
            if(isCompleted&&isSuccess)
                Console.WriteLine("Perfect");
            if(isCompleted||isSuccess)
                Console.WriteLine("Great");
            if(isCompleted&& !isSuccess)
                Console.WriteLine("Nice Try");
            
            int a = 5;
            int b = 4;
            bool result = a<b;
            Console.WriteLine(result);
            result = a>b;
            Console.WriteLine(result);
            result = a>=b;
            Console.WriteLine(result);

            // mod

            int modOfNum = a%2;
            Console.WriteLine(modOfNum);
        }
    }
}

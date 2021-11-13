using System;

namespace basic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker hasan = new Worker();
            hasan.Name = "Hasan";
            hasan.Surname = "Kavakli";
            hasan.Age = 29;
            hasan.WorkerInfo();
            Worker mehmet = new Worker();
            mehmet.Name = "Mehmet";
            mehmet.Surname = "Subasi";
            mehmet.Age = 22;
            mehmet.WorkerInfo(); 
        }

        class Worker
        {
            public string Name;
            public string Surname;

            public int Age;

            public void WorkerInfo(){
                Console.WriteLine("Name: "+ Name+" Surname: "+ Surname);
            }
        }
    }
}

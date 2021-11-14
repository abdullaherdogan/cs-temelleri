using System;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker merve = new Worker("Merve","Yaman","mrv@mail.com");
            merve.WorkerInfo();
        }
    }
}

class Worker
{
    public string Name;
    public string Surname;
    public string Mail;

    public Worker(string _Name,string _Surname,string _Mail)
    {
        this.Name = _Name;
        this.Surname = _Surname;
        this.Mail = _Mail;
    }
    public void WorkerInfo()
    {
        Console.WriteLine("Name: "+ Name+" Surname: "+Surname);
    }
}

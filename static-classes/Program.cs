using System;

namespace static_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker hasan = new Worker("Hasan","Baltacı");
            Console.WriteLine(Worker.TotalPaid);
            Worker mehmet = new Worker("Mehmet","Halit");
            Console.WriteLine(Worker.TotalPaid);
            
        }
    }
}

class Worker
{
    private static int _totalPaid;
    public static int TotalPaid{get=>_totalPaid;}

    private string _name;
    private string _surname;

    public string Name
    {
        get{
            return _name;
        }
        set{
            _name=value;
        }
    }
    public string Surname
    {
        get{
            return _surname;
        }
        set{
            _surname=value;
        }
    }
    static Worker()
    {
        _totalPaid = 0;
    }
    public Worker(string name,string surname)
    {
        this.Name= name;
        this.Surname=surname;
        _totalPaid += 2800;
    }
}
using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ferhat = new Student("Ferhat","Aslan",1);
            ferhat.Downgrade();
            ferhat.StudentInfo();
        }
    }
}

class Student
{
    private string name;
    private string surname;
    private int yearOfSchool;

    public string Name {get=> name;set=>name = value;}
    public string Surname { get=>surname;set=>surname=value; }
    public int YearOfSchool
    {
        get=> yearOfSchool;
        set
        {
            if (value<1)
            {
                Console.WriteLine("Year of school can not be less than 1");
                yearOfSchool=1;
            }
            else
            {
                yearOfSchool=value;
            }
        }
    }

    public Student(string _name,string _surname,int _yearOfSchool)
    {
        Name = _name; // atamaları get set verdiğimiz proplara yapıyoruz
        Surname = _surname;
        YearOfSchool = _yearOfSchool;
    }
    public void Downgrade()
    {
        this.YearOfSchool = this.YearOfSchool-1; // propu değiştiriyoruz
    }
    public void StudentInfo()
    {
        Console.WriteLine("Name:   "+name);
        Console.WriteLine("Surname:   "+surname);
        Console.WriteLine("Year of School:   "+yearOfSchool);

    }
}

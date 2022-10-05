using System;
using System.Runtime.InteropServices;

class Person
{
    public string FirstName { get; set; }    
    public string LastName { get; set; }

    public void PrintName()
    {
        Console.WriteLine($"My name is {FirstName} {LastName}!");
    }
}

class Employee : Person
{
    public void Work()
    {
        Console.WriteLine("I am a drummer!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee { FirstName = "Joey", LastName = "Jordison" };
        employee.PrintName();
        employee.Work();

        Student student = new Student { FirstName = "Lars", LastName = "Ulrich" };
        student.PrintName();
        student.Learn();
    }
}

class Student : Person
{
    public void Learn()
    {
        Console.WriteLine("I am learn how to drum");
    }
}

using System;
using System.Collections.ObjectModel;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name : ");
        string name = Console.ReadLine();
        Console.Write("Enter age : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of Subject 1 : ");
        double mark1 = double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject 2 : ");
        double mark2 = double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject 3 : ");
        double mark3 = double.Parse(Console.ReadLine());
        Console.Write("Enter Grade : ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter Mobile Number : ");
        long mobile = long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id : ");
        string mail = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Trainee Details are : ");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Age : {age}");
        Console.WriteLine($"Mobile : {mobile}");
        Console.WriteLine($"Mark1 : {mark1}");
        Console.WriteLine($"Mark2 : {mark2}");
        Console.WriteLine($"Mark 3 : {mark3}");
        double totalMarks = mark1+mark2+mark3;
        double averageMarks =(mark1+mark2+mark3)/3;
        Console.WriteLine($"Total : {totalMarks}");
        Console.WriteLine($"Average : {averageMarks}");
        Console.WriteLine($"Grade : {grade}");
        Console.WriteLine($"Mail id : {mail}");
    }
}
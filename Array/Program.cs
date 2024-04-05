using System;
namespace Array;
class Program 
{
    public static void Main(string[] args)
    {
        string[] names = new string[5]{"Mani","Ganesh","Venkat","Suresh","Venkat"};
        for(int i=0;i<names.Length;i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.WriteLine();
        Console.Write("Enter a name to search in array : ");
        string userInput=Console.ReadLine();
        bool isNamePresent=true;
        for(int i=0;i<names.Length;i++)
        {
            if(userInput == names[i])
            {
                isNamePresent=false;
                Console.WriteLine($"The name is present in array at {i} index position");
                break;
            }
        }
        if(isNamePresent) 
        {
            Console.WriteLine("The name is not present in array using for loop");
        }

        foreach(string s in names)
        {
            if(userInput == s)
            {
                isNamePresent=false;
                Console.WriteLine($"The name is present in array");
                break;
            }
        }
        if(isNamePresent) 
        {
            Console.WriteLine("The name is not present in array using foreach loop");
        }
    }
}
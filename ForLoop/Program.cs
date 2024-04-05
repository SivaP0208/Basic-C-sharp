using System;
namespace ForLoop;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter starting number : ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter ending number : ");
        int end = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i=start;i<end;i++)
        {
            sum+=(i*i);
        }
        Console.WriteLine(sum);
    }
}